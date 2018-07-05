using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoSceneHelpers : MonoBehaviour {

	public GameObject infoWindow;
	private float originalTS = 1;

	// Use this for initialization
	void Start () {
		Invoke("GetTimeScale", 0.1f);
	}

	void GetTimeScale(){
		originalTS = Time.timeScale;
		ShowInfoWindow();
	}
	
	public void ShowInfoWindow(){
		infoWindow.SetActive(true);
		Time.timeScale = 0;
	}

	public void CloseInfoWindow(){
		infoWindow.SetActive(false);
		Time.timeScale = originalTS;
	}
}
