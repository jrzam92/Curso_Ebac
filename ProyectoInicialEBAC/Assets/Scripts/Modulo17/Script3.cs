using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour
{
    public Script1 Bool1;
    public Script2 Bool2; 
    public bool Bool_3 = false;
    
    private void FixedUpdate()
    {

        if (Bool1.ownBool1 || Bool2.ownBool2)
        {
            Bool_3=true;
            
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
       
      
        else 
        {
            Bool_3 = false;
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}
