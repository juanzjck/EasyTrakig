using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertice : MonoBehaviour
{
    private int nombre;
    public GameObject vector;
   
    public GameObject camino;
    public GameObject Predecesor;
    public float distancia;
    public bool visitado;
    public bool etiqueta;
    public int acumulado; // lleva el acoulado de cada nodo

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        distancia =Vector3.Distance(vector.transform.position, Predecesor.transform.position); 
        GameObject c=Instantiate(camino,vector.transform);
        c.GetComponent<Transform>().localScale = new Vector3(distancia,0.1f,0.1f);
        c.GetComponent<Transform>().position = vector.transform.position;


        //
        Vector3 pos = Predecesor.transform.position;

        Vector3 dir = vector.transform.position - Predecesor.transform.position;
        Vector3 newDir = Vector3.RotateTowards(vector.transform.forward,dir,1, 0.0f);
        // transform.rotation=Quaternion.LookRotation(newDir);

        //  Debug.DrawLine(pos, pos + dir * 10, Color.red, Mathf.Infinity);
       
        Gizmos.DrawLine(vector.transform.position, Predecesor.transform.position);
        camino.transform.LookAt(Predecesor.transform);
    }	
}
