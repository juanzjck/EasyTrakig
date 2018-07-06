using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListSignature 
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

    public bool Delete(Signature s)
    {
        if (!isEmpty ())
        {
            if (begin == end && begin.getSignature() == s)
            {
                begin = end = null;
            }
            else if (begin.getSignature() == s)
            {
                begin = begin.getNext();
                return true;
            }
            else
            {
                NodoSignature ant = begin;
                NodoSignature temp = begin.getNext();
                while (temp != null && temp.getSignature() != s)
                {
                    ant = temp;
                    temp = temp.getNext();
                }
                if (temp != null)
                {
                    ant.setNext(temp.getNext());
                    if (temp == end)
                    {
                        end = ant;
                    }
                    return true;
                }
                return false;
            }
        }
        return false;
    }
}
