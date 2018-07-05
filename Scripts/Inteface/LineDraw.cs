using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDraw : MonoBehaviour {
    private LineRenderer lineRender;
    private float speed = 6f;
    private float count;
    private float dist;
    public Transform destination;
    public Transform origin;
    public List<Transform> nodes;
    public void setLineDraw(Transform destination,Transform origin){
        this.origin = origin;
        this.destination = destination;


    }
	// Use this for initialization
	void Start () {
        lineRender = GetComponent<LineRenderer>();
        lineRender.SetPosition(0,origin.position);
        lineRender.SetWidth(0.45f,0.45f);
        dist = Vector3.Distance(destination.position,origin.position);

	}
	
	// Update is called once per frame
	void Update () {
       
            
            for (int i=0; i< dist;i++){
                count += 0.1f;
                float x = Mathf.Lerp(0, dist, count);
                Vector3 pointA = origin.position;
                Vector3 pointB = destination.position;
                Vector3 pointALongLine = x * Vector3.Normalize(pointB - pointA) + pointA;
                lineRender.SetPosition(1, pointALongLine);

            }
           /* if (count < dist)
            {

            }*/ 
          

	}
}
