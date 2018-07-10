using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodoTransform {
    Transform data;
    NodoTransform siguiente;
    public NodoTransform(Transform data, NodoTransform siguiente){
        this.data=data;
        this.siguiente=siguiente;
    }
    public void setSiguiente(NodoTransform siguiente){
        this.siguiente = siguiente;

    }
    public NodoTransform getSiguiente()
    {
        return siguiente;

    }
    public Transform getData(){
        return data;
    }
    public void setData(Transform data)
    {
        this.data = data;
    }
}
