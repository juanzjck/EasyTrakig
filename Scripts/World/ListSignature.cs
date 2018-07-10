using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListSignaute 
{
    NodoSignature begin;
  
    public bool isEmpty(){
        return begin == null;

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
    public int GetEnumerato()
    {
        NodoSignature aux = begin;
        int l = 0;
        while (aux != null)
        {
            l++;
            aux = aux.next;
        }
        return l;

    }
    public NodoSignature getNodoInd(int i){

        NodoSignature aux = begin;
        int c = 0;
        while (c < i)
        {
            c++;
            aux = aux.next;
        }
        return aux;

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
            begin = n;

        }else{
            begin.setBefore(n);
            n.setNext(begin);
            begin = n;

        }
        Debug.Log("ADDED");
       
    }

    public void print(){
        NodoSignature aux = begin;
       
        while (aux!=null)
        {
            Debug.Log(aux.signature.title);
            aux = aux.next;
        }
       

    }
    public void ordenar()
    {
        if(length()>1){
            
            for (int i = 0; i < length() ; i++)
            {
                for (int j = i; j < length()-1; j++)
                {
                    if (getInd(i).hourBegin > getInd(j + 1).hourBegin)
                    {
                        Signature tmp = getInd(j + 1);

                        getNodoInd(j + 1).setSignature(getInd(i));
                        getNodoInd(j).setSignature(tmp);
                    }
                }
            }
        }
        print();
       
    }
}
