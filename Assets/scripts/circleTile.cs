using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class circleTile : MonoBehaviour {


	public Toggle rigidBodyToggle;
	//public Image rigidBodyToggleImage;

	//public Sprite toggleOn, toggleOff;

	// Use this for initialization
	void Start () {

		rigidBodyToggle = GameObject.Find("rigidBodyToggle").GetComponent<Toggle>();
		//rigidBodyToggleImage = GameObject.Find("rigidBodyToggle").GetComponent<Image>();

		GetComponent<Renderer>().material.color = new Color(PathMaker.colorFloat,PathMaker.colorFloat,PathMaker.colorFloat,1f);
//
//		float randNum = Random.Range(0.00f,1.00f);
//
//		if(randNum < 0.33f){
//
//			GetComponent<Renderer>().material.color = new Color(1f,PathMaker.colorFloat,PathMaker.colorFloat,1f);
//
//		}else if(randNum > 0.33f && randNum < 0.66f){
//
//			GetComponent<Renderer>().material.color = new Color(PathMaker.colorFloat,1f,PathMaker.colorFloat,1f);
//
//		} else if(randNum > 0.66f && randNum < 1.00f){
//
//			GetComponent<Renderer>().material.color = new Color(PathMaker.colorFloat,PathMaker.colorFloat,1f,1f);
//
//		}

		if (rigidBodyToggle.isOn){

			//rigidBodyToggleImage.sprite = toggleOn;
			GetComponent<Rigidbody>().isKinematic = false;
		}else {

			//rigidBodyToggleImage.sprite = toggleOff; 
			GetComponent<Rigidbody>().isKinematic = true;

		}

	

	}
	
	// Update is called once per frame
	void Update () {

	}




//	public void onClick(){
//
//		if (GetComponent<Rigidbody>().isKinematic){
//
//			GetComponent<Rigidbody>().isKinematic = false;
//
//		} else{
//
//			GetComponent<Rigidbody>().isKinematic = true;
//
//		}
//
//	}
}
