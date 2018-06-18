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
        Debug.Log("Done");

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
    public bool passMatchAndMail(string email, string pass){
        NodoStudent aux = begin;
        bool f=false;
        while (aux != null)
        {
            if (aux.student.email == email && aux.student.email == pass )
            {
                f=true;

            }
            aux = aux.next;
        }
        return f;

    }
    public Student searchMail(string email){
        NodoStudent aux = begin;
        Student studen = null;
        while (aux != null)
        {
            if (aux.student.email == email)
            {
                Debug.Log("done email");
                studen = aux.student;

            }
            aux = aux.next;
        }
        return studen;

    }
    public Student searchName(string name){
        NodoStudent aux = begin;
        Student studen = null;
        while(aux!=null){
            if(aux.student.name==name){
                studen = aux.student;
                Debug.Log("done");
            }
            aux = aux.next;
        }
        return studen;

    }
}
