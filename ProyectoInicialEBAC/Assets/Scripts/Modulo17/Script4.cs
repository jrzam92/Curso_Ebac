using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script4 : MonoBehaviour
{
    public Script1 Bool1;
    public Script2 Bool2;
    
    public bool Bool_4;
    
    private void FixedUpdate()
    {

        if (Bool1.ownBool1 && Bool2.ownBool2)
        {
            
            Bool_4 = true;
           GetComponent<Renderer>().material.color = Color.green;
        }


        else
        {
            Bool_4 = false;
            GetComponent<Renderer>().material.color = Color.gray;
        }
    }
}
