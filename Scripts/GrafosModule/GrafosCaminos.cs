using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrafosCaminos : MonoBehaviour {
    public GameObject[] aristas;
	// Use this for initialization
	void Start () {
        aristas = GameObject.FindGameObjectsWithTag("Vertices");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void  DistaciaMinima(){



    }
}
