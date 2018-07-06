using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButonListBlocks : MonoBehaviour {

    private string Name;
    public Text ButtonText;


    public void SetName(string name)
    {
        Name = name;
        ButtonText.text = name;
    }
    public void Button_Click()
    {
       

    }
}
