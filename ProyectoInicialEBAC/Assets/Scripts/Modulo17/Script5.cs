using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script5 : MonoBehaviour
{

    public Script3 Bool3;
    public Script4 Bool4;
    public bool ownBool5;
   
    private void FixedUpdate()
    {


        if (Bool3.Bool_3 || Bool4.Bool_4)
        {
             
            ownBool5 = true;
            GetComponent<MeshRenderer>().material.color = Color.white;
        }


        else if (Bool3.Bool_3 && Bool4.Bool_4)
        {
            ownBool5 = false;
            GetComponent<MeshRenderer>().material.color = Color.black;
        }



    }
}
