using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public bool ownBool1 = false;
    
     
    private void FixedUpdate()
    {
        if (ownBool1)
        {
            ownBool1 = true;
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            ownBool1 = false;
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}
