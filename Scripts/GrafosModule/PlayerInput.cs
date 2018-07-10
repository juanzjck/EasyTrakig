using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput : MonoBehaviour {

    public Transform node;
    public Transform startNode;
    public Transform endNode;
    private List<Transform> blockPath = new List<Transform>();
    public GameObject controller;
   
    public bool clicked;

	// Update is called once per frame
	void Update () {
      
    }

    public void allPaths(){

        GameObject[] paths= GameObject.FindGameObjectsWithTag("Node");
        ListTransfor pathsTrasform=new ListTransfor();
        clicked = !clicked;

        if(clicked!=false){

            foreach (GameObject n in paths)
            {
                pathsTrasform.add(n.transform);
            }
            pathsTrasform.drawLine();

        }else{
            pathsTrasform.clearLine();
        }
            

    }
    /// <summary>
    /// Button for Set Starting node.
    /// </summary>
    public void btnStartNode()
    {
        if (node != null)
        {
            Node n = node.GetComponent<Node>();

            // Making sure only walkable node are able to set as start.
            if (n.isWalkable())
            {
                // If this is a new start node, we will just set it to blue.
                if (startNode == null)
                {
                    Renderer rend = node.GetComponent<Renderer>();
                    rend.material.color = Color.blue;
                }
                else
                {
                    // Reverse the color of the previous node
                    Renderer rend = startNode.GetComponent<Renderer>();
                    rend.material.color = Color.white;

                    // Set the new node as blue.
                    rend = node.GetComponent<Renderer>();
                    rend.material.color = Color.blue;
                }

                startNode = node;
                node = null;
            }
        }
    }

    /// <summary>
    /// Button for Set End node.
    /// </summary>
    public void btnEndNode()
    {
        if (node != null)
        {
            Node n = node.GetComponent<Node>();

            // Making sure only walkable node are able to set as end.
            if (n.isWalkable())
            {
                // If this is a new end node, we will just set it to cyan.
                if (endNode == null)
                {
                    Renderer rend = node.GetComponent<Renderer>();
                    rend.material.color = Color.cyan;
                }
                else
                {
                    // Reverse the color of the previous node
                    Renderer rend = endNode.GetComponent<Renderer>();
                    rend.material.color = Color.white;

                    // Set the new node as cyan.
                    rend = node.GetComponent<Renderer>();
                    rend.material.color = Color.cyan;
                }

                endNode = node;
                node = null;
            }
        }
    }

    /// <summary>
    /// Button for find path.
    /// </summary>
    public void btnFindPath()
    {   
        
        // Only find if there are start and end node.
        if (startNode != null && endNode != null)
        {
            //limpar camino
            GameObject[] drawlineners = GameObject.FindGameObjectsWithTag("Node");
            foreach (GameObject n in drawlineners)
            {
                Renderer rend = n.GetComponent<Renderer>();
                rend.material.color = Color.gray;
                n.GetComponent<LineDraw>().endDraw();

            }
            // Execute Shortest Path.
            ShortestPath finder = gameObject.GetComponent<ShortestPath>();
            List<Transform> paths = finder.findShortestPath(startNode, endNode);
            int sizeOfList = paths.Count;
            foreach (Transform path in paths){

                Renderer rend = path.GetComponent<Renderer>();
                rend.material.color = Color.grey;
            }

            ListTransfor pathsList=new ListTransfor();
           
          
            // Colour the node red.

            foreach (Transform path in paths)
            {
                Renderer rend = path.GetComponent<Renderer>();
                LineDraw line = GetComponent<LineDraw>();
                rend.material.color = Color.blue;
                //line.origin = path;


                pathsList.add(path);

            }
           
            pathsList.print();
            pathsList.drawLine();

        }
    }


    /// <summary>
    /// Clear all the block path.
    /// </summary>
    public void btnClearBlock()
    {   
        // For each blocked path in the list
        foreach(Transform path in blockPath)
        {   
            // Set walkable to true.
            Node n = path.GetComponent<Node>();
            n.setWalkable(true);

            // Set their color to white.
            Renderer rend = path.GetComponent<Renderer>();
            rend.material.color = Color.white;

        }
        // Clear the block path list and 
        blockPath.Clear();
    }

    /// <summary>
    /// Button to restart level.
    /// </summary>
    public void btnRestart()
    {
        Scene loadedLevel = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadedLevel.buildIndex);
    }

    /// <summary>
    /// Coloured unwalkable path to black.
    /// </summary>
    private void colorBlockPath()
    {
        foreach(Transform block in blockPath)
        {
            Renderer rend = block.GetComponent<Renderer>();
            rend.material.color = Color.black;
        }
    }

    /// <summary>
    /// Refresh Update Nodes Color.
    /// </summary>
    private void updateNodeColor()
    {
        if (startNode != null)
        {
            Renderer rend = startNode.GetComponent<Renderer>();
            rend.material.color = Color.blue;
        }

        if (endNode != null)
        {
            Renderer rend = endNode.GetComponent<Renderer>();
            rend.material.color = Color.cyan;
        }
    }

}
