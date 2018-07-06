using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListSchedule: MonoBehaviour {
    
    public GameObject button;
    public GameObject scrollBox;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ListSignatures(ListSignaute  Signatures){
        int cont = 0;
        Debug.Log("Comenzando");
        for (int i = 0; i < Signatures.GetEnumerato();i++){
           
            GameObject btn = Instantiate(button);
            btn.SetActive(true);
            ButtonClass  btnblocks = btn.GetComponent<ButtonClass>();
            btnblocks.SetName(Signatures.getInd(i).title);
            btnblocks.setBlock(Signatures.getInd(i).block);
            int x = 0;
            int y = cont;
            int z = 0;
            btn.GetComponent<Transform>().position = new Vector3(x, y, z);
            cont += 100;
            btn.transform.SetParent(scrollBox.transform.parent);

        }
    }
}
