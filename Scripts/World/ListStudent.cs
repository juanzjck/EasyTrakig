using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListStudent 
{
    public ListStudent()
    {

    }
    NodoStudent begin, end;
    public bool isEmpty()
    {
        return begin == null & end == null;

    }
    public void add(Studient s)
    {
        NodoStudent n = new NodoStudent(s, null, null);
        if (isEmpty())
        {
            begin = end = n;

        }
        else
        {
            begin.setBefore(n);
            n.setNext(begin);
            begin = n;

        }


    }
    public int lengt()
    {
        NodoStudent aux = begin;
        int i = 0;
        while (aux != null)
        {
            i++;
            aux = aux.next;

        }
        return i;

    }
    public Studient searchName(NodoStudent aux,string name)
    {
        Studient valid = null;
        if(aux!=null){
            if(aux.studient.name==name){
                valid=aux.studient;
            }else{
                valid=searchName(aux.next, name);
               
            }
           
        }
        return valid;
    }
}
