using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListSchedule : MonoBehaviour
{

    public GameObject button;
    public GameObject scrollBox;
    public GameObject[] buttons;
    public bool clicked=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        buttons = GameObject.FindGameObjectsWithTag("Clase");
       // Organizar();
	}
    public void actualzar(){
       
            foreach (GameObject n in buttons)
            {
                Destroy(n);

            }

       
    }
    public void Organizar()
    {
       
      
       
    }
    public void ListSignatures(ListSignaute  Signatures){
        int c = 0;
        if(clicked==false){
           
            Debug.Log("Comenzando...");

            for (int i = 0; i < Signatures.GetEnumerato(); i++)
            {

                var btn = Instantiate(button);

                btn.SetActive(true);
                ButtonClass btnblocks = btn.GetComponent<ButtonClass>();
                btnblocks.SetName(Signatures.getInd(i).title);
                btnblocks.setBlock(Signatures.getInd(i).block);

                int x = 0;
                int y = c;
                int z = 0;
                c = c + 150;

               
                btn.transform.SetParent(scrollBox.transform,false);
                btn.transform.parent = scrollBox.transform;
                RectTransform rt = btn.GetComponent<RectTransform>();
                rt.anchoredPosition = rt.transform.position;
                rt.localPosition = new Vector2(0, -y);
               // btn.transform.SetPositionAndRotation(pos,scrollBox.transform.localRotation);

            }


        }else{

            actualzar();
        }
        clicked = !clicked;
    }
}
