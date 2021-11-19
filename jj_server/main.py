from fastapi import FastAPI
from enum import Enum

app = FastAPI()

class CategoryName(str, Enum):
    beverage = "beverage"
    coffee = "coffee"
    smoothie = "smoothie"
    food = "food"
    all = "all"

class Member:
    def __init__(self, name):
        self.name = name
        self.recent_ordered = ""
        self.most_ordered = []
        self.visit_num = 0
        self.id = -1
        self.order = {}
    
    def name_info(self):
        return "이름 : " + self.name
    
    def recent_ordered_info(self):
        return "가장 최근에 주문한 메뉴 : " + self.recent_ordered

    def most_ordered_info(self):
        # return "가장 많이 주문한 메뉴 : " + self.most_ordered
        return self.most_ordered

    def visit_num_info(self):
        return "방문 횟수 : " + str(self.visit_num)

    def id_info(self):
        return "아이디 : " + str(self.id)

    def order_info(self):
        return self.order


class Menu:
    def __init__(self, name):
        self.name = name
        self.price = 0
        self.sugar = ""
        self.temperature = 0
        self.calorie = 0
        self.milk = ""
    catecory:CategoryName = None


yeon = Member("yeon-dong")
yeon.recent_ordered = "아메리카노"
yeon.most_ordered = ["아메리카노"]
yeon.visit_num = 5
yeon.id = 1
yeon.order = {"아메리카노" : 4, "카페라떼" : 1}

owjs = Member("owjs3901")
owjs.recent_ordered = "카페라떼"
owjs.most_ordered = ["아인슈페너"]
owjs.visit_num = 3
owjs.id = 2
owjs.order = {"카페라떼" : 1, "아인슈페너" : 2}

juhyung = Member("juhyung")
juhyung.recent_ordered = "연유라떼"
juhyung.most_ordered = ["딸기스무디"]
juhyung.visit_num = 8
juhyung.id = 3
juhyung.order = {"딸기스무디" : 5, "아인슈페너" : 2, "연유라떼" : 1}


americano = Menu("아메리카노")
americano.price = 4000
americano.category = CategoryName.coffee
americano.sugar = "sugar-free"
americano.temperature = 3
americano.calorie = 30
americano.milk = "non-milk"


cafe_latte = Menu("카페라떼")
cafe_latte.price = 5000
cafe_latte.category = CategoryName.coffee
cafe_latte.sugar = "sugar-free"
cafe_latte.temperature = 3
cafe_latte.calorie = 50
cafe_latte.milk = "milk"


milk_latte = Menu("연유라떼")
milk_latte.price = 5500
milk_latte.category = CategoryName.coffee
milk_latte.sugar = "sugar"
milk_latte.temperature = 3
milk_latte.calorie = 60
milk_latte.milk = "milk"


strawberry_smoothie = Menu("딸기스무디")
strawberry_smoothie.price = 6000
strawberry_smoothie.category = CategoryName.smoothie
strawberry_smoothie.sugar = "sugar"
strawberry_smoothie.temperature = 1
strawberry_smoothie.calorie = 100
strawberry_smoothie.milk = "non-milk"


cake = Menu("케이크")
cake.price = 4500
cake.catecory = CategoryName.food
cake.sugar = "sugar"
cake.temperature = 0
cake.calorie = 120
cake.milk = "non-milk"


cookie = Menu("쿠키")
cookie.price = 3000
cookie.catecory = CategoryName.food
cookie.sugar = "sugar"
cookie.temperature = 0
cookie.calorie = 200
cookie.milk = "non-milk"


member_info = {1 : yeon, 2 : owjs, 3 : juhyung}
member_name = ["yeon-dong", "owjs3901", "juhyung"]
next_id = [4]

# beverage = ["아메리카노", "카페라떼", "아인슈페너", "연유라떼", "딸기스무디", "바닐라 라떼"]
menu_list = [americano, cafe_latte, milk_latte, strawberry_smoothie, cake, cookie]
order_list = ["카페라떼", "아메리카노", "아메리카노"]

@app.get("/")
def read_root():
    return {"Welcome" : "짱친 cafe!"}


## show user info
@app.get("/user/{customer_id}")
async def show_info(customer_id : int):
    customer = member_info[customer_id]
    customer.name_info()
    customer.recent_ordered_info()
    customer.most_ordered = [key for key, val in customer.order.items() if max(customer.order.values()) == val]
    customer.most_ordered_info()
    customer.visit_num += 1
    customer.visit_num_info()
    customer.id_info()
    print("\n방문해주셔서 갑사합니다 ~^~^~")
    return customer


## create user
@app.post("/user/")
async def generate_id(name):
    if name in member_name:
        # print(name + " 님은 회원 정보가 이미 존재합니다.")
        return {"res": False}
    else:
        customer = Member(name)
        member_name.append(name)
        customer.visit_num = 1
        customer_id = next_id[0]
        next_id[0] += 1
        member_info[customer_id] = customer
        # print(customer.name + " 님의 회원 정보가 등록되었습니다.\n회원 아이디는 [" + str(customer_id) + "] 입니다.")
        return customer


## delete user
@app.delete("/user/{customer_id}")
async def delete_id(customer_id : int):
    if customer_id in member_info:
        customer = member_info[customer_id]
        member_name.remove(customer.name)
        del member_info[customer_id]
        print("회원 정보가 삭제되었습니다.")
        return {"res": True}
    else:
        print("존재하지 않는 회원 아이디입니다.")
        return {"res": False}


## show all users
@app.get("/user/")
async def show_member():
    return member_name


## new order
@app.post("/order/{user_id}/{product}")
async def order(user_id : int, product):
    customer = member_info[user_id]
    if product in list(map(lambda x:x.name, menu_list)):
        if product in customer.order:
            customer.order[product] += 1 
        else:
            customer.order[product] = 1
        customer.recent_ordered = product
        order_list.append(product)
        # print(product + " 이(가) 주문되었습니다.")
        return {"res" : True}
        # print(product + " 은(는) 존재하지 않는 메뉴입니다.")
    return {"res" : False}


## show order list
@app.get("/order/")
async def get_order_list():
    return order_list


## delete order
@app.delete("/order/{product}")
async def delete_order(product):
    if product in order_list:
        order_list.remove(product)
        return order_list
    return {"res" : False}


## append menu
@app.post("/menu/{category}/{product}")
async def append_beverage(product, category : CategoryName, price : int, calorie : int, temper = 0,  milk = "non-milk", sugar = "sugar"):
    for x in menu_list:
        if x.name == product:
            # print(product + " 은(는) 이미 메뉴에 있는 음료입니다.")
            return {"res" : False}

    menu = Menu(product)
    menu.price = price
    menu.category = category
    menu.calorie = calorie
    menu.milk = milk
    menu.temperature = temper
    menu.sugar = sugar
    menu_list.append(menu)
    # print(beverage + " 이(가) 추가되었습니다.")
    return menu


## remove beverage menu
@app.delete("/menu/{product}")
async def remove_beverage(product):
    del_menu = list(filter(lambda x:x.name == product, menu_list))
    if del_menu:
        menu_list.remove(*del_menu)
        # print(product + " 메뉴가 삭제되었습니다.")
        return {"res" : True}

    # print(product + " 은(는) 메뉴에 존재하지 않습니다.")
    return {"res" : False}


## show menu
@app.get("/menu/{category}")
async def show_menu(category: CategoryName):
    if category == CategoryName.beverage:
        return list(map(lambda e:e.name, filter(lambda e:e.catecory != "food", menu_list)))       
    elif category == CategoryName.all:
        return list(map(lambda e:e.name, menu_list))
    else:
        return list(map(lambda e:e.name, filter(lambda e:e.catecory == category, menu_list)))
