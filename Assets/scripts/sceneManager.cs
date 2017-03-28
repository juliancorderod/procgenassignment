using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneManager : MonoBehaviour {

	public Transform pathmakerSpherePrefab;

	public Button restartButton;

	// Use this for initialization
	void Start () {

		//restartButton = GameObject.Find("restartButton").GetComponent<Button>();

		restartButton= this.GetComponent<Button>();

	}
	
	// Update is called once per frame
	void Update () {


		//restartButton.onClick.AddListener(buttonClick);


//		if (Input.GetKeyDown(KeyCode.R)){
//
//			PathMaker.globalTileCount = 0;
//
//			PathMaker.colorFloat = 1f;
//
//			Instantiate(pathmakerSpherePrefab,Vector3.zero,Quaternion.identity);
//
//			SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex);
//
//
//
//		}


		
	}

	public void onClick(){
		PathMaker.globalTileCount = 0;

		PathMaker.colorFloat = 1f;

		Instantiate(pathmakerSpherePrefab,Vector3.zero,Quaternion.identity);

		SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex);
	}
}
