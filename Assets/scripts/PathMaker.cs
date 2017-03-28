using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PathMaker : MonoBehaviour {

	int counter = 0;

	public Transform floorPrefab;
	public Transform pathmakerSpherePrefab;

	public static int globalTileCount;

	public int maxTileSize;

	public static float colorFloat = 1f;

	public Slider duplicatorSlider;




	// Use this for initialization
	void Start () {

		duplicatorSlider = GameObject.Find("duplicatorSlider").GetComponent<Slider>();
		
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log(globalTileCount);

		//if(counter < 200f){

			float randNum = Random.Range(0.00f,1.00f);

			if(randNum < 0.25f){

				transform.Rotate (0f,Random.Range(0f,50),0f);

			}else if(randNum > 0.25f && randNum < 0.5f){

				transform.Rotate (0f,Random.Range(-50f,0),0f);

		} else if(randNum > duplicatorSlider.value && randNum < 1.00f){

				Instantiate(pathmakerSpherePrefab,transform.position, transform.rotation);

			}

			Instantiate(floorPrefab,transform.position,transform.rotation);
			transform.Translate(2.5f,0f,0f);
			counter ++;
			globalTileCount ++;

			colorFloat -= 0.0005f;

//		} else{
//
//			Destroy(gameObject);
//
//		}

		if (globalTileCount > maxTileSize){

			Destroy(gameObject);

		}


		
	}
}
