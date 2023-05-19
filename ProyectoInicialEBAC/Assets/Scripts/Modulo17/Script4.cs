using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script4 : MonoBehaviour
{
    public boolx1 ownBool1;
    bool ownBool;
    public GameObject prefab_cube;
    private void FixedUpdate()
    {
        
        ownBool= (ownBool1 == true)?false : true;
        if (ownBool == true)
        {
            prefab_cube.GetComponent<Renderer>().material.color = Color.white;
        }
        else
        {
            prefab_cube.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
