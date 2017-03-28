using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rigidBodyToggleScript : MonoBehaviour {

	public Sprite toggleOn, toggleOff;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(GetComponent<Toggle>().isOn){

			GetComponent<Image>().sprite = toggleOn;
		}else{

			GetComponent<Image>().sprite = toggleOff;
		}
		
	}
}
