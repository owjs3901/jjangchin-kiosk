# 시연영상
[![Watch the video](https://img.youtube.com/vi/yjWj_VPAHco/hqdefault.jpg)](https://www.youtube.com/watch?v=yjWj_VPAHco)
-------------------------
# 2021 서울 하드웨어 해커톤 : 메뉴 추천 키오스크
- **[오정민](https://github.com/owjs3901)(팀장 - HW/SW 개발자)**
> 프로젝트 매니저<br />
> 기획 및 개발 총괄

- **[임동연](https://github.com/yeon-dong)(팀원 - SW 개발자)**
> 키오스크 UI/UX Design<br />
> 기획 및 개발

- **[서윤재](https://github.com/yuunni)(팀원 - HW 개발자)**
> RPI4 Tizen Setting<br />
> 하드웨어 설계 및 연동

# 2021 AI 융합 경진대회
![Alt text](/img/AIposter.jpg)
- **[최주형](https://github.com/Juhyung98)(팀장 - SW 개발자)**
> 서버 개발 총괄
> 키오스크 서버 개발

# 팀원 사진
![Alt text](/img/member.jpg)
![Alt text](/img/member2.jpg)

# 개요
구매 내역 분석을 통한 상품 추천 키오스크를 개발한다. <br />
이를 통하여 사용자들이 키오스크를 사용하는 시간이 줄어들어 키오스크 앞의 인구 밀집도를 낮출 수 있다. <br />
또한 사용자 기다림을 줄여 점진적으로 키오스크에 투자되는 비용을 감소시키며 감염 확산을 방지한다. <br />
키오스크의 UI/UX를 개선하여 사용에 어려움을 겪는 사람들에게 더욱 간편한 결제를 제공한다.

![Alt text](/img/image2.jpg)
![Alt text](/img/jjangchin-kiosk.jpg)
# Specification
* 라즈베리파이 4<br />
* Display<br />
* Infrared Motion Sensor HC-SR501<br />
* Barcode Scanner<br />

![Alt text](/img/image1.jpg)

# 기능
* 바코드 인식을 통한 사용자 인식<br />
* 각각의 사용자에 따른 메뉴 추천<br />
* 쉬운 UI의 메뉴 주문<br />
* 센서를 통한 모션 감지<br />

# 파일 리스트

파일명|내용
---|---
KioskPage1.xaml|추천이 없는 메뉴 주문 페이지
KioskPage2.xaml|사용자 추천 메뉴 주문 페이지
MainPage1.xaml|바코드 인식 페이지
Scene1Page.xaml|최초 페이지
CompletePage.xaml|주문 완료 페이지
EasySelectPage.xaml|쉬운 UI의 주문 페이지
SelectPage.xaml|메뉴 선택화면
BlackScreen.Xaml|최초 키오스크의 빈 화면, 모션 인식 후 Scene1Page로 이동

# 코드 기여자

**오정민**
파일명 |
:---- |
KioskPage1.xaml(.cs)|  
KioskPage2.xaml(.cs) | 
MainPage1.xaml(.cs)  |
Scene1Page.xaml(.cs)|
CompletePage.xaml(.cs)|
EasySelectPage.xaml(.cs)|
SelectPage.xaml(.cs)|
Scene1.cs|
Class1.cs|
Program.cs|

**임동연**
파일명 |
:---- |
KioskPage1.xaml(.cs)|  
KioskPage2.xaml(.cs) | 
MainPage1.xaml(.cs)  |
Scene1Page.xaml(.cs)|
CompletePage.xaml(.cs)|
EasySelectPage.xaml(.cs)|
SelectPage.xaml(.cs)|
Scene1.cs|

**서윤재**
파일명 |
:---- |
MainPage1.xaml(.cs)|  
BlackScreen.Xaml(.cs) | 
SelectPage.xaml(.cs)  |
Scene1.cs|
Class1.cs|
Program.cs|

**최주형**
파일명 |
:---- |
jj_server/main.py|

# 구현사항
* Peripheral GPIO : 적외선 모션 감지 센서, GPIO 4<br />
* 바코드 스캐너(B-210)




