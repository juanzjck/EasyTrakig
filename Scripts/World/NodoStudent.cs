using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodoStudent  {
    public Studient studient;
    public NodoStudent before,next;

    public NodoStudent(Studient studient,NodoStudent before,NodoStudent next){
        this.studient = studient;
        this.before = before;
        this.next = next;
    }

    public void setStudent(Studient studient){

        this.studient = studient;
    }
    public void setBefore(NodoStudent before)
    {

        this.before = before;
    }
    public void setNext(NodoStudent next)
    {

        this.next = next;
    }


    public Studient getStudent(Studient studient)
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

