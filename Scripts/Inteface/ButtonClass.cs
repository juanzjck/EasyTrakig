using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonClass : MonoBehaviour {
    public string Name;
    public Text ButtonText;
    public GameObject block;
    public GameObject controllergraf;
    public GameObject start;
    public void SetName(string name)
    {
        
        ButtonText.text = name;
    }
    public void setBlock(GameObject block){
        this.block = block;

    }
    public void Start()
    {
        start = GameObject.Find("PlayerCapsule");
        controllergraf = GameObject.FindWithTag("GraphController");
    }
    // Update is called once per frame
    void Update () {
		
	}
    public void showPath()
    {
        PlayerInput input = controllergraf.GetComponent<PlayerInput>();

        input.startNode=start.transform;
        input.endNode=block.transform;

        input.btnFindPath();
        start.GetComponent<PlayerNode>().Closer();
    }
}
