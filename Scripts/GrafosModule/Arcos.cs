using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Arcos:MonoBehaviour{
    public Vertice inicio, siguiente;
    public float distancia;
    public Arcos(Vertice inicio,Vertice siguiente){
        this.inicio = inicio;
        this.siguiente = siguiente;
    }
    public Arcos(Vertice inicio, Vertice siguiente,float disancia)
    {
        this.inicio = inicio;
        this.siguiente = siguiente;
        this.distancia = disancia;
    }

}
