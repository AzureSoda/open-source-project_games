





# Flappy BangUlEe, 플래피 방울이

유니티를 활용하여 저희 집 고양이 방울이를 테마로 방울이가 점프하는 게임을 개발하였습니다.  

https://user-images.githubusercontent.com/49617190/204946622-e49dc28b-c3db-43c2-8144-e84237251176.mp4

게임플레이 영상입니다

---

## 목차

1. [프로젝트 기획 이유](#프로젝트-기획-이유)
2. [게임설명](#게임설명)
3. [에셋 설명](#에셋-설명)
4. [코드,애니메이션 설명](#코드,애니메이션-설명)
5. [플레이하는법- 스크린샷](#플레이하는법--스크린샷)
6. [리뷰,피드백](#리뷰,피드백)
7. [릴리즈](#릴리즈)
8. [느낀점, 배운점, 아쉬운점](#느낀점,배운점,아쉬운점)
9. [참고한곳](#참고한곳)
10. [라이센스](#라이센스)

---

## 📝프로젝트 기획 이유
<img src="https://user-images.githubusercontent.com/49617190/204704448-6c2ea206-b5cb-454a-acaa-9dc55741fdbf.png"  width="500" height="700">

저희집 고양이 방울이 입니다.
<img src="https://user-images.githubusercontent.com/49617190/204705259-c445467c-a907-4c8a-93b7-3f2c0fbfc6e6.gif"  width="800" height="800">      
평소에 유니티로 게임 개발하는 것에 관심이 많았었는 데 어떤 주제로 게임을 만들지 고민하다가 집에서 방울이가 점프하는 것을 보고 이를 주제로 게임을 만들면 재미있겠다는 생각이 들어서 이러한 프로젝트를 기획하게 되었습니다. 
---
## 📝게임설명
방울이 캐릭터를 터치해서 빨간색 파이프를 통과해서 점수를 얻어 최대한 많은 점수를 획득하는 게임입니다.  
간단한 조작의 게임으로 화면을 터치하면 고양이 캐릭터가 공중에서 점프합니다. 그러나 캐릭터의 낙하속도가 빠르므로 타이밍을 맞추어 터치하지 않으면 캐릭터가 곧장 바닥으로 떨어지거나 파이프에 부딪히기 때문에 높이를 조정해 가면서 파이프사이를 통과해서 고득점을 노리는 게임입니다.
*플래피 버드 게임을 참고하였습니다.  
---

## 📝에셋설명

### 로고
<img src="https://user-images.githubusercontent.com/49617190/204998282-a576f0e2-73f7-4da1-8cae-11bb1149a9d0.png"  width="700" height="500">
도트 찍는 프로그램을 통해 게임의 로고를 자체 제작하였습니다

### 이미지
<img src="https://user-images.githubusercontent.com/49617190/204997935-1ba30814-7872-42be-9b33-9c0af704b6de.png"  width="700" height="500">
도트 찍는 프로그램을 통해 캐릭터를 자체 제작하였습니다

### 사운드 에셋 출처
무료로 사용가능한 곳에서 다운 받아 사용했습니다.
https://soundeffect-lab.info/sound/button/

---

## 📝코드,애니메이션 설명


![image](https://user-images.githubusercontent.com/49617190/204999428-1a855d17-a4b8-4ce7-82f9-acffeac951f4.png)    
CurrentScore.cs 현재 스코어를 저장하고 전달하는 코드입니다.

![image](https://user-images.githubusercontent.com/49617190/205000513-3e0ccb85-4c32-40d7-80ef-cf5920ae310f.png)  
BestScore.cs 스코어중에서 가장 좋은 스코어를 저장하고 전달하는 코드입니다.

![image](https://user-images.githubusercontent.com/49617190/204999637-de41bf50-9c06-49b2-aab8-529e62271ea5.png)  
Replay.cs 게임을 다시 실행하게 만드는 코드입니다. 버튼에 적용시켜서 게임을 다시 시작하게 만듭니다.

![image](https://user-images.githubusercontent.com/49617190/204999888-375232a0-7185-4e7c-b830-ed1671c46531.png)   
Firststart.cs 게임의 첫화면을 지정하는 코드입니다. 

![image](https://user-images.githubusercontent.com/49617190/205000038-17b776cb-240f-49a8-bce5-ef9ea9917974.png)  
generatepipe.cs 장애물인 파이프를 생성하는 코드입니다. 랜덤으로 y값을 바꾸어서 생성되도록 만들었고, 시간이 지나면 destroy함수를 통해서 시간이 지나면 자동으로 사라지게 만들었고 효과음을 넣어서 파이프를 통과할 경우 소리가 나게 만들었습니다.  

![image](https://user-images.githubusercontent.com/49617190/205000836-2897f73d-ed99-4ac8-bc5a-4bf20bd123c1.png)  
jump.cs 캐릭터인 방울이가 점프하게 만드는 코드입니다. 터치할 때 마다 점프하도록 만들었고, 충돌판정을 넣어서 부딪힐 경우 게임 오버 씬으로 전환되도록 만들었습니다. 효과음을 주어서 점프할 때마다 소리가 나도록 만들었습니다.

![image](https://user-images.githubusercontent.com/49617190/205001173-1a08147d-3929-4d47-807c-c43220e4be8b.png)  
move.cs 게임의 속도를 조정하는 코드입니다. public float를 써서 에디터에서 speeed를 편리하게 조절하도록 만들었습니다. 피드백 결과 현재의 속도가 적절하다는 의견이 많아서 현재의 속도로 결정하게 되었습니다.

![image](https://user-images.githubusercontent.com/49617190/205001615-7942f7b1-9170-4699-810a-54a4708bd23c.png)  
pipemovement.cs 장애물인 파이프가 속도에 맞춰서 게임의 진행방향인 옆으로 이동하도록 만든 코드입니다. public float를 써서 에디터에서 speeed를 편리하게 조절하도록 만들었습니다. 피드백 결과 현재의 속도가 적절하다는 의견이 많아서 현재의 속도로 결정하게 되었습니다.

groundanimation.anim  
땅 에셋에 효과를 주어서 게임이 더 움직이도록 보이게 만듭니다.  

---

## 📝플레이하는법- 스크린샷
이 레포지토리의 릴리즈에서 최신 버전을 다운로드해서 안드로이드폰에 APK파일을 넣어준 뒤 설치를 하면 실행이 됩니다.

![KakaoTalk_20221201_173233861](https://user-images.githubusercontent.com/49617190/205004477-d8883203-9a02-4730-a15b-10a776e015f7.png)  
게임 로딩할때 나오는 창입니다, 유니티의 기능을 활용하여 게임의 로고가 나오도록 만들었습니다.  

![KakaoTalk_20221201_173233861_01](https://user-images.githubusercontent.com/49617190/205004556-9ed10770-dc0d-4ef6-984a-259d97de6075.png)  
게임의 첫화면 입니다. 게임의 로고와 캐릭터를 크게 키워서 잘 보이도록 만들었고 가운데 버튼을 눌러서 게임을 진행할 수 있습니다.

![KakaoTalk_20221201_173233861_03](https://user-images.githubusercontent.com/49617190/205004695-a8274b21-2c51-44b3-961c-72cfecddb68e.png)  
게임 플레이 화면입니다 화면 제일 오른쪽에는 게임의 스코어가 나오도록 만들었고 고양이 캐릭터를 터치하면 위로 점프합니다. 랜덤 생성되는 파이프를 피해서 앞으로 진행하면 됩니다.

![KakaoTalk_20221201_173233861_02](https://user-images.githubusercontent.com/49617190/205004844-4f24a430-dff8-472e-b54c-d764e74fb595.png)  
게임 오버시 나오는 페이지입니다. 베스트 스코어는 게임을 진행하는 동안 최고점수를 표시하고 아래 점수는 방금 플레이한 판의 점수를 기록합니다. 방금 플레이한 판의 점수가 최고점수를 갱신할시에 베스트 스코어로 바뀝니다.


## 📝리뷰,피드백
| 리뷰,피드백    | 별점      |
|-----------|------------|
| 게임 난이도가 어렵다, 게임은 재미있다 | 5/5 |
| 디자인이 아쉽다. 디자인은 디자이너에게 | 4/5 |
| 땅 애니메이션이 안맞는다, 첫 화면에서 이미지가 작게나온다. | 4/5 |
| 난이도가 어렵다. 좀 낮추면 좋을 것 같다. | 4/5 |

---

## 📝릴리즈
v1.0.0: 게임의 첫번째 버전입니다.

v1.1: 게임의 현재 최신 업데이트 버전 입니다. 피드백을 반영하여 어색했던 땅의 애니메이션 부분과 첫 화면을 수정하였습니다. 이 릴리즈를 설치해 게임을 플레이하시면 됩니다.

---


## 📝느낀점, 배운점, 아쉬운점
게임을 내가 직접 만들어 볼 수 있다는 점이 좋았고, 강의 시간때 교수님이 말씀하신 것처럼 본인이 하고싶은 프로젝트를 진행하고 본인의 깃허브에 자랑스럽게 올릴 수있다는 말을 기억하고 프로젝트를 진행하였다. 내가 왜 컴퓨터공학과에 진학했는지 게임을 만들면서 다시금 생각할 수 있었고 내가 좋아하는 프로젝트를 하다보니 타 프로젝트보다 더 주도적으로 진행할 수 있었다. 아쉬웠던 점은 캐릭터에 애니메이션을 더 넣으면 좋았을 것 같았는데 나의 부족한 디자인 능력과 센스 때문에 진행하지 못한 점이 아쉬웠고 종강후 겨울방학 동안에 유니티나 다른 게임엔진에 대해서 더 배워서 내가 그동한 구상하고 기획했던 게임 프로젝트들을 직접 만들어 봐야겠다는 각오도 다질 수 있었다.

---
## 📝참고한곳
무료 쉬운 게임 개발 강의 - 3시간만에 개발, 출시, 수익화까지 완성 - https://www.youtube.com/watch?v=EqoU1PodQQ4&t=6591s  
[유니티] 플래피버드 30분 만에 만들기 (자막 있음) - https://www.youtube.com/watch?v=RgTZRT-LHcw&t=2s  


## 📝라이센스
MIT License를 따릅니다. 레포지토리 안에 license.md파일을 만들어 두었습니다.

### 📝게임 시연 영상 ###
https://www.youtube.com/shorts/A_zOd4DcTT0

## 🖥️Developers
19101191 김경준


<hr>
## This is a manual for English speakers

## Flappy Bang UlEe
Using Unity, I developed a game that cat,BangUlEe jump under the theme of our cat BangUlEe.

https://user-images.githubusercontent.com/49617190/204946622-e49dc28b-c3db-43c2-8144-e84237251176.mp4  
It's a game play video

## Table of Contents

1. [Reason for project planning](#Reason-for-project-planning)
2. [Game description](#Game-description)
3. [Asset Description](#Asset-Description)
4. [Code, Animation Description](#Code,-Animation-Description)
5. [How to play - Screenshot](#How-to-play--Screenshot)
6. [Review, feedback](#Review,-feedback)
7. [Release](#Release)
8. [Feeling, learning, disappointing](#Feeling,-learning,-disappointing)
9. [Reference](#Reference)    
10. [License](#License)  

---

## 📝 Reasons for project planning
<img src="https://user-images.githubusercontent.com/49617190/204704448-6c2ea206-b5cb-454a-acaa-9dc55741fdbf.png" width="500" height="700">

This is my cat, BangUlEe.
<img src="https://user-images.githubusercontent.com/49617190/204705259-c445467c-a907-4c8a-93b7-3f2c0fbfc6e6.gif" width="800" height="800">
I was interested in developing a game with UNITY. Usually, I was thinking about what topic to make a game, and I thought it would be fun to make a game with this topic after seeing BangUlEe jump at home.
---
## 📝 Game description
The bell touches the character and passes through the red pipe to score as many points as possible.
Touch the screen with a simple game and the cat character jumps in the air. However, the character's drop speed is fast, so if you don't touch it at the right time, the character falls directly to the floor or hits the pipe, so it's a game that aims for high scores by passing through the pipes while adjusting the height.
*Refer to the Flappy Bird game.
---

## 📝 Asset Description

### The logo
<img src="https://user-images.githubusercontent.com/49617190/204998282-a576f0e2-73f7-4da1-8cae-11bb1149a9d0.png" width="700" height="500">
I made the logo of the game myself through a dot-taking program

### Image
<img src="https://user-images.githubusercontent.com/49617190/204997935-1ba30814-7872-42be-9b33-9c0af704b6de.png" width="700" height="500">
I made my own character through a dot-taking program

### Sound Asset Source
I downloaded and used it at a place where it was available for free.
https://soundeffect-lab.info/sound/button/

---

## 📝 Code, animation description


![image](https://user-images.githubusercontent.com/49617190/204999428-1a855d17-a4b8-4ce7-82f9-acffeac951f4.png)  
CurrentScore.cs Code to store and forward the current score.

![image](https://user-images.githubusercontent.com/49617190/205000513-3e0ccb85-4c32-40d7-80ef-cf5920ae310f.png)  
Code to store and deliver the best score among BestScore.cs scores.

![image](https://user-images.githubusercontent.com/49617190/204999637-de41bf50-9c06-49b2-aab8-529e62271ea5.png)  
Code that causes the game Replay.cs to run again. Apply to buttons to restart the game.

![image](https://user-images.githubusercontent.com/49617190/204999888-375232a0-7185-4e7c-b830-ed1671c46531.png)  
Code that specifies the first screen of the Firststart.cs game.

![image](https://user-images.githubusercontent.com/49617190/205000038-17b776cb-240f-49a8-bce5-ef9ea9917974.png)  
Code for generating generatepipe.cs obstruction pipe. It was created by randomly changing the y value, and it was made to disappear automatically over time through the destroy function over time, and it was made to make a sound when passing through the pipe by adding a sound effect.

![image](https://user-images.githubusercontent.com/49617190/205000836-2897f73d-ed99-4ac8-bc5a-4bf20bd123c1.png)  
Code to make the character jump.cs jump. I made it jump every time I touched it, and I made it switch to the game over scene if I hit it by adding a crash decision. I made a sound effect every time I jumped.

![image](https://user-images.githubusercontent.com/49617190/205001173-1a08147d-3929-4d47-807c-c43220e4be8b.png)  
Code to adjust the speed of the move.cs game. I made it convenient to adjust the speed in the editor by using the public float. As a result of the feedback, there were many opinions that the current speed was appropriate, so we decided on the current speed.

![image](https://user-images.githubusercontent.com/49617190/205001615-7942f7b1-9170-4699-810a-54a4708bd23c.png)  
pipemovement.cs Code for pipe, an obstacle, to move to the side, which is the direction of the game, at speed. I made it convenient to adjust the speed in the editor by using the public float. As a result of the feedback, there were many opinions that the current speed was appropriate, so we decided on the current speed.

groundanimation.anim
It has an effect on the ground asset, making the game look more mobile.

---

## 📝How to play - Screenshot
Download the latest version from the release of this repository, insert the APK file into your Android phone, and install it to run.

![KakaoTalk_20221201_173233861](https://user-images.githubusercontent.com/49617190/205004477-d8883203-9a02-4730-a15b-10a776e015f7.png)
This is the window that comes out when loading the game, and I made it so that the logo of the game comes out using Unity's.

![KakaoTalk_20221201_173233861_01](https://user-images.githubusercontent.com/49617190/205004556-9ed10770-dc0d-4ef6-984a-259d97de6075.png)
This is the first screen of the game. The logo and characters of the game are enlarged to make it look good, and you can press the middle button to proceed with the game.

![KakaoTalk_20221201_173233861_03](https://user-images.githubusercontent.com/49617190/205004695-a8274b21-2c51-44b3-961c-72cfecddb68e.png)
This is the game play screen On the far right side of the screen, the score of the game is made, and when you touch the cat character, it jumps up. Avoid randomly generated pipes and proceed forward.

![KakaoTalk_20221201_173233861_02](https://user-images.githubusercontent.com/49617190/205004844-4f24a430-dff8-472e-b54c-d764e74fb595.png)
This is the page that comes out when the game is over. The best score displays the highest score during the game, and the score below records the score of the game you just played. The score of the game you just played will change to the best score when you renew the highest score.


## 📝Review, feedback
| Review, Feedback | Stars |
|-----------|------------|
| It's hard to play. It's fun | 5/5 |
| The design is unfortunate. Design to Designer | 4/5 |
| The ground animation doesn't fit, the image comes out small on the first screen. | 4/5 |
| The difficulty level is difficult. I think it would be good to lower it a little. | 4/5 |

---

## 📝 Release
v1.0.0: This is the first version of the game.

v1.1: Current latest update for the game. The animation part of the land that was awkward and the first screen was modified by reflecting the feedback. You can install this release to play the game.

---


## 📝 Feeling, learning, disappointing
I liked that I could make my own games, and as the professor said during the lecture, I remembered that I could proceed with the project I wanted to do and proudly upload it on my GitHub. I was able to think about why I went to the computer engineering department again while making a game, and as I did my favorite project, I was able to take more initiative than other projects.

## 📝 References
https://www.youtube.com/watch?v=EqoU1PodQQ4&t=6591s
https://www.youtube.com/watch?v=RgTZRT-LHcw&t=2s


## 📝 License
Follow the MIT License. I've created a license.md file in my repository.

### 📝Game Demonstration Video ###
https://www.youtube.com/shorts/A_zOd4DcTT0

## ## 🖥️Developers
19101191 Kim Kyung-Jun

