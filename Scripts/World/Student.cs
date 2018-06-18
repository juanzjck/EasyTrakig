using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : User
{
    public Schedule schedule;

    public Student(){
        
    }
    public void addSignature(Signature s)
    {
        if (schedule==null){

            schedule = new Schedule();
        }
        schedule.addSgnature(s);
    }

}


