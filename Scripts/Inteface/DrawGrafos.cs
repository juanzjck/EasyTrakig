using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGrafos : MonoBehaviour {
    public GameObject puntoObjeto;
    public List<GameObject> puntos;
	// Use this for initialization
	void Start () {
        puntos.Add(puntoObjeto);
        foreach(GameObject punto in puntos){
            Instantiate(punto);
        }
       
	}
	
	// Update is called once per frame
	void Update () {
	   
	}
}
