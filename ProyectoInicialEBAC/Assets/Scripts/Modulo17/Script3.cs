using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour
{
    public boolx1 ownBool1;
    public boolx2 ownBool2;
    public GameObject prefab_cube;
    private void FixedUpdate()
    {

        if (ownBool1.Bool_1)
        {
            prefab_cube.GetComponent<Renderer>().material.color = Color.red;
        }
        else if(ownBool1.Bool_1)
        {
            prefab_cube.GetComponent<Renderer>().material.color = Color.white;
        }
        else if (ownBool2.Bool_2)
        {
            prefab_cube.GetComponent<Renderer>().material.color = Color.red;
        }
        else if(ownBool2.Bool_2)
        {
            prefab_cube.GetComponent<Renderer>().material.color = Color.cyan;
        }
    }
}
