using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Studient : User
{
    public Schedule schedule;

    public Studient(){
        
    }
    public void addSignature(Signature s)
    {

        schedule.addSgnature(s);
    }

}


