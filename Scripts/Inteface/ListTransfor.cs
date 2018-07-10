using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTransfor {
    NodoTransform begin;
    public ListTransfor()
    {

    }
 
    public bool isEmpty()
    {
        return begin == null;

    }
    public NodoTransform getInd(int i ){
        NodoTransform aux = begin;
        int c = 0;
        while(c<i){
            c++;
        }
        return aux;

    }
    public void add(Transform s)
    {
        NodoTransform n = new NodoTransform(s, null);
        if (lengt()==0)
        {
            begin  = n;

        }
        else
        {
            n.setSiguiente(begin);
            begin = n;
           

        }

        Debug.Log("Done ADDED lISR"+s.ToString());

    }
    public void clearLine(){
      
            begin=null;
  
    }
    public void  drawLine(){
        NodoTransform aux = begin;
        Debug.Log("===============================Caminos========================");
        float dist = 0;
        while (aux != null){
            if(aux.getSiguiente()!=null){
                LineDraw ln = aux.getData().GetComponent<LineDraw>();
                ln.origin = aux.getData();
                ln.destination = aux.getSiguiente().getData();
                ln.startDraw();
                float dis = Vector3.Distance(aux.getData().position, aux.getSiguiente().getData().position);
                dist = dist + dis;
                Debug.Log("Del punto:" + aux.getData().name + "Hasta:" + aux.getSiguiente().getData().name + "Distancia:" + dis);

               

            }
            aux = aux.getSiguiente();
             }
        Debug.Log("=========================TOTAL==============================");
        Debug.Log("Distancia tota:   "+dist);
      
    }
    public void print(){
        NodoTransform aux = begin;
     
        while (aux != null)
        {
            Debug.Log(aux.getData().ToString());
           
            aux = aux.getSiguiente();

        }

    }
    public int lengt()
    {
        NodoTransform aux = begin;
        int i = 0;
        while (aux != null)
        {
            i++;
            aux = aux.getSiguiente();

        }
        return i;




    }
}
