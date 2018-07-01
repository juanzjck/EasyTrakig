using System.Collections;
using System.Collections.Generic;

public class Arcos{
    public Arista inicio, siguiente;
    public float distancia;
    public Arcos(Arista inicio,Arista siguiente){
        this.inicio = inicio;
        this.siguiente = siguiente;
    }
    public Arcos(Arista inicio, Arista siguiente,float disancia)
    {
        this.inicio = inicio;
        this.siguiente = siguiente;
        this.distancia = disancia;
    }

}
