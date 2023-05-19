using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public boolx1 ownBool1 ;
    public GameObject prefab_cube;
     
    private void FixedUpdate()
    {
        if (ownBool1.Bool_1)
        {
            prefab_cube.GetComponent<Renderer>().material.color = Color.black;
        }
        else
        {
            prefab_cube.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
