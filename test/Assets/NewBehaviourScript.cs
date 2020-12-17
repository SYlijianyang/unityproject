using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

  Vector3   world; 

float speed=100;//物体的移动速度
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
     Vector3  screenpos=Camera.main.WorldToScreenPoint(transform.position);//物体的世界坐标转化成屏幕坐标 

  Vector3 e=Input.mousePosition;//鼠标的位置 

  //当点击鼠标左键时 

  if(Input.GetMouseButton(0)){ 

     e.z=screenpos.z;//1.因为鼠标的屏幕 Z 坐标的默认值是0，所以需要一个z坐标 

    world=Camera.main.ScreenToWorldPoint(e);  

     speed=100;
     transform.LookAt(world); //物体朝向鼠标     

     transform.Translate(Vector3.forward * speed * Time.deltaTime); 
  } 


 
}
}
