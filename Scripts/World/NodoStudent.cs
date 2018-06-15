using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodoStudent  {
    public Student student;
    public NodoStudent before,next;

    public NodoStudent(Student studient,NodoStudent before,NodoStudent next){
        this.student = studient;
        this.before = before;
        this.next = next;
    }

    public void setStudent(Student studient){

        this.student = studient;
    }
    public void setBefore(NodoStudent before)
    {

        this.before = before;
    }
    public void setNext(NodoStudent next)
    {

        this.next = next;
    }


    public Student getStudent(Student studient)
    {

        return studient;
    }
    public NodoStudent getBefore(NodoStudent before)
    {

        return before;
    }
    public NodoStudent getNext(NodoStudent next)
    {

        return next;
    }
}

