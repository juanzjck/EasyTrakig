using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Juan Pablo, Lucia,Sergio
public class PlayerNode : Node {
    //nodos en la escena
    public GameObject[] nodes;

    // Use this for initialization
	void Start () {
       //encontrar todos lo Gameobjects con tag Node en la escena
        nodes =GameObject.FindGameObjectsWithTag("Node");
        //Agregar el nodo mas secano por primera vez
        addNeighbourNode(GetCloserNodo());
	}
	
	// Update is called once per frame
	void Update () {
        Closer();
	}
    //clase para actualizar el nodo mas cercano
    public void Closer(){
        addNeighbourNode(GetCloserNodo());
    }
    //Objetene el Nodo cercano
    public Transform GetCloserNodo()
    {
        //limia la lista actual de nodos vecinos
        getNeighbourNode().Clear();

        Transform aux = null;
        float minDist = Mathf.Infinity;
        //loop por cada Nodo en el array nodes verifica si es mas cercano
        foreach (GameObject node in nodes)
        {
            //busca el nodo principal del player para realizar la comparacion
            if (node.name != "PlayerCapsule")
            {
                float dist = Vector3.Distance(transform.position, node.transform.position);
                if (dist < minDist)
                {
                    aux = node.transform;
                    minDist = dist;

                }
            }
        }
        return aux;
    }
}

