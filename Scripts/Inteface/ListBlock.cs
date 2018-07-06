using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListBlock : MonoBehaviour {
    public GameObject[] nodes;
    public GameObject button;
    public GameObject scrollBox;
	// Use this for initialization
	void Start () {
        nodes = GameObject.FindGameObjectsWithTag("Node");
        ListNodes();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ListNodes()
    {
        int cont=0;
        foreach(GameObject node in nodes){
            
            if(node.name!="Camino" && node.name != "PlayerCapsule" ){
                GameObject btn = Instantiate(button);
                btn.SetActive(true);
                btn.GetComponent<ButonListBlocks>().block = node;
                ButonListBlocks btnblocks = btn.GetComponent<ButonListBlocks>();
                btnblocks.SetName(node.name);
            
                int x = 0;
                int y = cont;
                int z = 0;
                btn.GetComponent<Transform>().position = new Vector3(x, y, z);
                cont += 100;
                btn.transform.SetParent(scrollBox.transform.parent);
                //btn.transform.position = scrollBox.transform.position;



            }
             

           
        }
    }
}
