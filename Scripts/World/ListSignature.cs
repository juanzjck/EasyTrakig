using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListSignaute 
{
    NodoSignature begin, end,next,before;
  
 

    public bool isEmpty(){
        return begin == null & end == null;

    }
    public void add(Signature s)
    {
        NodoSignature n = new NodoSignature(s,null,null);
        if(isEmpty()){
            begin = end = n;

        }else{
            begin.setBefore(n);
            n.setNext(begin);
            begin = n;

        }


    }
   
       
    
    public bool addS(Signature s)
    {
        NodoSignature aux = begin;
        while (aux != null)
        {
            if (aux.getSignature()+aux.getStudent().compareTo(s) == 0)
            {
                break;
            }
            aux = aux.getNext();
        }
        if (aux != null)
        {
            if (aux == begin)
            {
                addS(s);
                return true;
            }
            else
            {
                NodoSignature ant = aux.getBefore();
                NodoSignature nuevo = new NodoSignature(s, ant, aux);
                ant.setNext(nuevo);
                aux.setBefore(nuevo);
                return true;
            }
        }
        return false;
    }

   
}
