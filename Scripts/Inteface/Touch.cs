using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject ins;

    // Use this for initialization
    void Start()
    {
       
        TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, true, true);
    }

    // Update is called once per frame
    void Update()
    {
        foreach(UnityEngine.Touch t in Input.touches){
            foreach(GameObject g in objects){

                if(g.transform.position.Equals(t.position)){
                    g.GetComponent<Events>().onClick();

                }

            }


        }
    }
}
