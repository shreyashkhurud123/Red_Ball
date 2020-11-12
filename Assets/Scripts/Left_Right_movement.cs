using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Left_Right_movement : MonoBehaviour
{	
	
	public float speed;
	int flag,flag1;
	Vector3 left,right,curr_pos,up;
	//Rigidbody rigidbody2d;
	
  void Start () {
	left = new Vector3(-2.1f, 0.0f, 0.0f);
	right = new Vector3(2.1f, 0.0f, 0.0f);
	up= new Vector3(0f, 4.1f, 0.0f);
	speed=5;
	flag= 0;
	flag1=0;
	//jmp_v = 20f;
	//rigidbody2d=transform.GetComponent<Rigidbody2d>();
  }

	private void OnMouseDown () {
		//rigidbody2d.velocity=Vector2.up * jmp_v;
		Debug.Log ("clicked on the ball...");
		curr_pos = transform.position + up;
		//flag=0;
		flag1=1;
	}
	
	
  void Update() {
	 
	 if(flag1==1){
		 
		 transform.position=Vector3.MoveTowards(transform.position,curr_pos,speed*3*Time.deltaTime);
		 if(transform.position==curr_pos){
			 flag1=0;
		 }
	 }
	 else if(flag<0){
		transform.position=Vector3.MoveTowards(transform.position,left,speed*Time.deltaTime);
	 }
	 else if(flag>0){
		 transform.position=Vector3.MoveTowards(transform.position,right,speed*Time.deltaTime);
	 }
	 
	

	 
     if (Input.GetMouseButtonDown (0)) {
         Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		 if(mousepos.x<0){
			 flag=-1;
		 }
		 else{
			 flag = 1;
		 }
     }
 }
}
