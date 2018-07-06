using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schedule{
    public ListSignaute siganatures;

    public Schedule(){


    }
    public ListSignaute GetSignautes(){
        return siganatures;
    }
    public void addSgnature(Signature s){
        if(siganatures==null){
            siganatures = new ListSignaute();

        }
        siganatures.add(s);
    }
}
