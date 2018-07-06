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
        float cont=0f;
        foreach(GameObject node in nodes){
            cont += 0.45f;
            GameObject btn = Instantiate(button);
            btn.SetActive(true);
            ButonListBlocks btnblocks = btn.GetComponent<ButonListBlocks>();
            btnblocks.SetName(node.name);
            btn.transform.SetParent(scrollBox.transform.parent);
            btn.transform.transform.position = scrollBox.transform.position;
            btn.transform.position = new Vector3(btn.transform.position.x,btn.transform.position.y-cont,btn.transform.position.z);
        }
    }
}
