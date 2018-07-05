using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signature :MonoBehaviour  {
    private string title,profesor;
    private int hourBegin, hourend;
    public GameObject bloque;
    public Signature(string title,string profesor,int hourBegin,int hourend){
        this.title = title;
        this.profesor = profesor;
        this.hourBegin = hourBegin;
        this.hourend = hourend;

    }

    public void setTitle(string titne){
        this.title = titne;

    }
    public void setProfesor(string profesor)
    {
        this.title =profesor;

    }

    public void setHourBegin(int hourBegin)
    {
        this.hourBegin = hourBegin;

    }
    public void setHourend(int hourend)
    {
        this.hourend = hourend;

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   
    public string ToString(){

        return "Titulo"+title+"Hora de inicio"+hourBegin+"Hora de fin"+hourend+"Profesor:"+profesor;
    }
}
