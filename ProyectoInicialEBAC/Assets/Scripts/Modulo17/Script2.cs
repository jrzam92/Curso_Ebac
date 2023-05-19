using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    public boolx2 ownBool2;
    public GameObject prefab_cube;
   
    private void FixedUpdate()
    {
        if (ownBool2.Bool_2)
        {
            prefab_cube.GetComponent<Renderer>().material.color = Color.white;
        }
        else
        {

            prefab_cube.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
