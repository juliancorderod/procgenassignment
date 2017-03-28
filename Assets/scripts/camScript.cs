using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camScript : MonoBehaviour {

	public GameObject pathMaker;

	public Slider camSlider;

//	float lerpVal = 1f;

	// Use this for initialization
	void Start () {

		camSlider = GameObject.Find("camSlider").GetComponent<Slider>();

		//camSlider.minValue = 50f;
		//camSlider.maxValue = 130f;

	}
	
	// Update is called once per frame
	void Update () {

		//transform.position = new Vector3(0f,camSlider.value,0f);

		GetComponent<Camera>().fieldOfView = camSlider.value;


//		if (Input.GetKey(KeyCode.UpArrow)){
//			transform.position += new Vector3(0f,-200f * Time.deltaTime,0f);
//		}
//		if (Input.GetKey(KeyCode.DownArrow)){
//			transform.position += new Vector3(0f,200f * Time.deltaTime,0f);
//		}

//
//		transform.position = new Vector3(Mathf.Lerp(0f,pathMaker.transform.position.x, lerpVal), 
//			transform.position.y, 
//			Mathf.Lerp(0f,pathMaker.transform.position.z, lerpVal));
			

	}
}
