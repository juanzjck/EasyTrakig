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
    public void add(Student s)
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

    public Student searchName( string name){
        return searchName(begin, name);

    }
    private Student searchName(NodoStudent aux,string name)
    {
        Student valid = null;
        if(aux!=null){
            if(aux.student.name==name){
                valid=aux.student;
            }else{
                valid=searchName(aux.next, name);
               
            }
           
        }
        return valid;
    }
}
