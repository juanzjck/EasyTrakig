using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNode : Node {
    public GameObject[] nodes;
    public bool settedPosition;
	// Use this for initialization
	void Start () {
        nodes =GameObject.FindGameObjectsWithTag("Node");
        addNeighbourNode(GetCloserNodo());
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    public Transform GetCloserNodo()
    {
        Transform aux = null;
        float minDist = Mathf.Infinity;
        if (settedPosition == false)
        {
            foreach (GameObject node in nodes)
            {
                if (node.name != "PlayerCapsule") {
                    float dist = Vector3.Distance(transform.position, node.transform.position);
                    if (dist < minDist)
                    {
                        aux = node.transform;
                        minDist = dist;

                    }

                
                }



            }


          
        }
        return aux;
    }
}
