using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour
{
    public boolx1 ownBool1;
    public boolx2 ownBool2;
    public GameObject prefab_cube;
    public boolx3 Bool_3;
    public bool Bool_y;
    private void FixedUpdate()
    {

        if (ownBool1.Bool_1 && ownBool2.Bool_2)
        {
            Bool_3.Bool_3=true;
            Bool_y = false;
            prefab_cube.GetComponent<Renderer>().material.color = Color.red;
        }
       
      
        else 
        {
            prefab_cube.GetComponent<Renderer>().material.color = Color.cyan;
        }
    }
}
