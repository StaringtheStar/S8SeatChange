# S8SeatChange V 1.0

-------
##### Made by 이준모(20190305~20190311)
###### 단순히 CNSA 5기 2-S8의 자리를 바꾸기 위해서만 만들어진 프로그램
-------

<img src="https://cnsa.hs.kr/images/hpm/intro/img_MHP1_02_02_09.png" width="128px" height="128px"></img>
>품격 있는 CNSA의 로고

<img src="https://image.flaticon.com/icons/svg/339/339779.svg" width="128px" height="128px"></img>
>S8SeatChange

## 사용법
처음 프로그램을 시작하면 자동으로 응용 프로그램 파일이 있는 곳에 Classmates.txt라는 텍스트 파일을 생성한다. 이 파일이 자리 배치의 정보를 담고 있다.

자리를 바꾸려면, **자리 바꾸기** 버튼을 누르면 된다. 배치를 저장하려면 상단 메뉴의 **저장**을 클릭한 후 **텍스트로 저장**을 클릭하면 자리 배치가 Classmates.txt라는 텍스트 파일로 저장된다.

그러나 꼭 Classmates.txt라는 파일을 사용할 필요는 없고, 다른 경로로 저장해둔 파일이 있다면 상단 메뉴의 **파일**을 클릭한 후 **배치 불러오기**를 클릭하면 현재 응용 프로그램의 경로에 있는 텍스트 파일뿐만 아니라, 다른 곳에 따로 저장해둔 파일도 사용할 수 있다.

Ctrl + S를 누르면 텍스트 또는 이미지로 저장할 수 있다.


## 후기
#### C#의 `List<T>`
  상당히 편리했는데도 모르고 있었어서 직접 노가다 코드를 작성했었다
  
  (현재는 다시 `List<T>`를 사용하여 다시 작성했다).
  `List<T>`의 장점을 몇 가지 나열해보자면
  
  - 다양한 자료형을 지정할 수 있음(ex. 일반적인 데이터 타입 + TextBox 등의 컴포넌트까지)
  - Python의 `List.Append`와 대응되는 `List.Add`
  
~~사실 리스트가 있는 걸 까먹고 있었다~~

#### Windows Forms의 편리함
  분명 WPF보다는 한계가 있지만, 인정할 건 인정해야겠다.
  
  매우
  
  편하다.
  
  디자인을 할 때도 위지윅
  
#### 앞으로의 개선
  - 자리를 드래그해서 위치를 바꿀 수도 있게 만들고 싶음(유동적인 자리)
  - 자리 수가 36자리로 고정하지 않고, 자유롭게 조절할 수 있게 하고 싶음
