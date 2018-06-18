using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schedule{
    private ListSignaute siganatures;

    public Schedule(){


    }
    public void addSgnature(Signature s){
        if(siganatures==null){
            siganatures = new ListSignaute();

        }
        siganatures.add(s);
    }
}
