using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemoSceneAbout : MonoBehaviour {
	[Header("ABOUT")]
	public string title;
	[TextArea]
	public string about;
	[TextArea]
	public string settings;

	[Header("UI CONTROLS")]
	public Text txt_title;
	public Text txt_content;
	public GameObject aboutWindow;

	// Use this for initialization
	void Start () {
		Time.timeScale = 0;
		txt_title.text = title;
		txt_content.text = "<b>ABOUT:</b> " + about;
		txt_content.text = "\n<b>SETTINGS:</b> " + settings;

		aboutWindow.SetActive(true);
	}

	public void StartDemoScene(){
		aboutWindow.SetActive(false);
		Time.timeScale = 1;
	}
	

}
