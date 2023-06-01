using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    public bool ownBool2 = false;
    
   
    private void FixedUpdate()
    {
        if (ownBool2==false)
        {
            ownBool2 = true;
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            ownBool2 = false;
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}
