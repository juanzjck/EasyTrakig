using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListSignaute 
{
    NodoSignature begin, end;
  
    public bool isEmpty(){
        return begin == null & end == null;

    }
    public int length(){
        NodoSignature aux = begin;
        int l = 0;
        while(aux!=null){
            l++;
            aux = aux.next;
        }
        return l;

    }
    public Signature getInd(int i){
        NodoSignature aux = begin;
        int c = 0;
        while (c<i)
        {
            c++;
            aux = aux.next;
        }
        return aux.signature;
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
        Debug.Log("ADDED");

    }

}
