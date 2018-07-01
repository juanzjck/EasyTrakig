using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
    public GameObject subMenu;
    public bool show;
	// Use this for initialization
	void Start () {
        show = false;
        subMenu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClcik(){
        show = !show;
        if (show == true)
        {
            subMenu.SetActive(true);

        }else{

            subMenu.SetActive(false);
        }


    }
}
