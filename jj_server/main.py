from fastapi import FastAPI
from enum import Enum

app = FastAPI()

class CategoryName(str, Enum):
    beverage = "beverage"
    coffee = "coffee"
    ade = "ade"
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
        self.cream = ""
        self.syrup = ""
        self.taste = ""
        self.fruit = ""
    category:CategoryName = None


yeon = Member("임동연")
yeon.recent_ordered = "아메리카노"
yeon.most_ordered = ["아메리카노"]
yeon.visit_num = 5
yeon.id = 2861183814422024
yeon.order = {"아메리카노" : 4, "카페라떼" : 1}

owjs = Member("오정민")
owjs.recent_ordered = "카페라떼"
owjs.most_ordered = ["아인슈페너"]
owjs.visit_num = 3
owjs.id = 2833670479702025
owjs.order = {"카페라떼" : 1, "아인슈페너" : 2}

juhyung = Member("최주형")
juhyung.recent_ordered = "연유라떼"
juhyung.most_ordered = ["딸기스무디"]
juhyung.visit_num = 8
juhyung.id = 2917100827764244
juhyung.order = {"딸기스무디" : 5, "아인슈페너" : 2, "연유라떼" : 1}


americano = Menu("아메리카노")
americano.price = 4000
americano.category = CategoryName.coffee
americano.sugar = "sugar-free"
americano.temperature = 3
americano.calorie = 30
americano.milk = "non-milk"
americano.cream = "non-cream"
americano.syrup = "non-syrup"


cafe_latte = Menu("카페라떼")
cafe_latte.price = 5000
cafe_latte.category = CategoryName.coffee
cafe_latte.sugar = "sugar-free"
cafe_latte.temperature = 3
cafe_latte.calorie = 50
cafe_latte.milk = "milk"
cafe_latte.cream = "non-cream"
cafe_latte.syrup = "non-syrup"


milk_latte = Menu("연유라떼")
milk_latte.price = 5500
milk_latte.category = CategoryName.coffee
milk_latte.sugar = "sugar"
milk_latte.temperature = 3
milk_latte.calorie = 60
milk_latte.milk = "milk"
milk_latte.cream = "non-cream"
milk_latte.syrup = "condensed-milk"


Einspener = Menu("아인슈페너")
Einspener.price = 5000
Einspener.category = CategoryName.coffee
Einspener.sugar = "sugar"
Einspener.temperature = 1
Einspener.calorie = 80
Einspener.milk = "milk"
Einspener.cream = "cream"
Einspener.syrup = "non-syrup"


vanilla_latte = Menu("바닐라라떼")
vanilla_latte.price = 5000
vanilla_latte.category = CategoryName.coffee
vanilla_latte.sugar = "sugar"
vanilla_latte.temperature = 1
vanilla_latte.calorie = 80
vanilla_latte.milk = "milk"
vanilla_latte.cream = "non-cream"
vanilla_latte.syrup = "vanilla"


cafe_mocha = Menu("카페모카")
cafe_mocha.price = 5300
cafe_mocha.category = CategoryName.coffee
cafe_mocha.sugar = "non-sugar"
cafe_mocha.temperature = 1
cafe_mocha.calorie = 100
cafe_mocha.milk = "milk"
cafe_mocha.cream = "non-cream"
cafe_mocha.syrup = "choco"


grapefruit_ade = Menu("자몽에이드")
grapefruit_ade.price = 6000
grapefruit_ade.category = CategoryName.ade
grapefruit_ade.sugar = "non-sugar"
grapefruit_ade.temperature = 1
grapefruit_ade.calorie = 100
grapefruit_ade.milk = "non-milk"
grapefruit_ade.cream = "non-cream"
grapefruit_ade.syrup = "syrup"
grapefruit_ade.taste = "no-sour"
grapefruit_ade.fruit = "grapefruit"


lemon_ade = Menu("레몬에이드")
lemon_ade.price = 6000
lemon_ade.category = CategoryName.ade
lemon_ade.sugar = "non-sugar"
lemon_ade.temperature = 1
lemon_ade.calorie = 180
lemon_ade.milk = "non-milk"
lemon_ade.cream = "non-cream"
lemon_ade.syrup = "syrup"
lemon_ade.taste = "sour"
lemon_ade.fruit = "lemon"


mango_ade = Menu("망고에이드")
mango_ade.price = 6000
mango_ade.category = CategoryName.ade
mango_ade.sugar = "sugar"
mango_ade.temperature = 1
mango_ade.calorie = 200
mango_ade.milk = "non-milk"
mango_ade.cream = "non-cream"
mango_ade.syrup = "syrup"
mango_ade.taste = "non-sour"
mango_ade.fruit = "mango"


orange_ade = Menu("오렌지에이드")
orange_ade.price = 6000
orange_ade.category = CategoryName.ade
orange_ade.sugar = "sugar"
orange_ade.temperature = 1
orange_ade.calorie = 200
orange_ade.milk = "non-milk"
orange_ade.cream = "non-cream"
orange_ade.syrup = "syrup"
orange_ade.taste = "non-sour"
orange_ade.fruit = "orange"


berry_ade = Menu("딸기에이드")
berry_ade.price = 6000
berry_ade.category = CategoryName.ade
berry_ade.sugar = "non-sugar"
berry_ade.temperature = 1
berry_ade.calorie = 150
berry_ade.milk = "non-milk"
berry_ade.cream = "non-cream"
berry_ade.syrup = "syrup"
berry_ade.taste = "non-sour"
berry_ade.fruit = "berry"


choco_cake = Menu("초코케이크")
choco_cake.price = 5000
choco_cake.category = CategoryName.food
choco_cake.sugar = "sugar"
choco_cake.temperature = 0
choco_cake.calorie = 300
choco_cake.milk = "non-milk"


strawberry_cake = Menu("딸기케이크")
strawberry_cake.price = 4500
strawberry_cake.category = CategoryName.food
strawberry_cake.sugar = "sugar"
strawberry_cake.temperature = 0
strawberry_cake.calorie = 230
strawberry_cake.milk = "non-milk"


sandwich = Menu("샌드위치")
sandwich.price = 3500
sandwich.category = CategoryName.food
sandwich.sugar = "non-sugar"
sandwich.temperature = 0
sandwich.calorie = 80
sandwich.milk = "non-milk"


cookie = Menu("쿠키")
cookie.price = 3000
cookie.category = CategoryName.food
cookie.sugar = "sugar"
cookie.temperature = 0
cookie.calorie = 200
cookie.milk = "non-milk"


member_info = {2861183814422024 : yeon, 2833670479702025 : owjs, 2917100827764244 : juhyung}
member_name = ["yeon-dong", "owjs3901", "juhyung"]
next_id = [0]

menu_list = [americano, cafe_latte, milk_latte, grapefruit_ade, choco_cake, strawberry_cake, sandwich, cookie, Einspener, berry_ade, mango_ade, lemon_ade, vanilla_latte, cafe_mocha]
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
@app.post("/user/{user_id}")
async def generate_id(user_id : int):
    if user_id in member_info:
        # print(name + " 님은 회원 정보가 이미 존재합니다.")
        return {"res": False}
    else:
        customer = Member("익명")
        member_name.append("익명")
        customer.visit_num = 1
        customer.id = user_id
        member_info[customer.id] = customer
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
        return list(map(lambda e:e.name, filter(lambda e:e.category != "food", menu_list)))       
    elif category == CategoryName.all:
        return list(map(lambda e:e.name, menu_list))
    else:
        return list(map(lambda e:e.name, filter(lambda e:e.category == category, menu_list)))
