using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListSignaute 
{
    NodoSignature begin, end;
  
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
        Debug.Log("ADDED");

    }

}
