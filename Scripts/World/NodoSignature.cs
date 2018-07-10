using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodoSignature  {

    public Signature signature;
    public NodoSignature before, next;

    public NodoSignature(Signature signature,NodoSignature before, NodoSignature next)
    {
        this.signature = signature;
        this.before = before;
        this.next = next;
    }

    public void setSignature(Signature signature)
    {

        this.signature = signature;
    }
    public void setBefore(NodoSignature before)
    {

        this.before = before;
    }
    public void setNext(NodoSignature next)
    {

        this.next = next;
    }


    public Signature getSignature(Student studient)
    {

        return signature;
    }
    public NodoSignature getBefore(NodoSignature before)
    {

        return before;
    }
    public NodoSignature getNext(NodoSignature next)
    {

        return next;
    }

}
