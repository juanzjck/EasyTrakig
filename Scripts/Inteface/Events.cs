using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour {
    public GameObject target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public  void onClick(){

        target.GetComponent<Controller>().signUp();
    }
}
