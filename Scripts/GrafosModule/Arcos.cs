using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arcos : MonoBehaviour {
    public GameObject inicial;
    public GameObject final;
    public float peso;
    public GameObject camino;
    public Arcos(){


    }
	void Start () {
       
        draw();
	}
	
	// Update is called once per frame
	void Update () {
       

	}
	public void draw()
	{
        Instantiate(camino);	
	}
    public void setCamino(GameObject camino){
        this.camino = camino;
    }
}
