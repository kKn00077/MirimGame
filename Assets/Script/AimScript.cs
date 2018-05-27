using UnityEngine;

using System.Collections;



public class AimScript : MonoBehaviour {

	public Texture2D AimTexture;//텍스쳐매핑을 집어넣는 변수(드래그)

	public Rect AimRect;
    public  int div=0;
	

	void Start(){

		//커서 감춤

		Cursor.visible = false;

        float left;
        float top;
        float width;
        float height;
		

		//aim 이미지의 크기를 구해서 화면 어디에 뿌려줄지까지만 계산
        if (div == 0)
        {
            left = (Screen.width - AimTexture.width) / 2;

            top = (Screen.height - AimTexture.height) / 2;

            width = AimTexture.width;

            height = AimTexture.height;
        }
        else
        {
            left = (Screen.width - AimTexture.width/div) / 2;

            top = (Screen.height - AimTexture.height/div) / 2;

            width = AimTexture.width/div;

            height = AimTexture.height/div;
        }

		

		//위에서 구한 좌표를 매개변수로 화면에 뿌림

		AimRect=new Rect(left, top, width, height);		

	}

	void Update(){}

	

	void OnGUI(){

		GUI.DrawTexture(AimRect,AimTexture);

		//Aim의 위치와 그림을 그려준다.

	}	

}