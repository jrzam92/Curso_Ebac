using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script4 : MonoBehaviour
{
    public boolx1 ownBool1;
    public boolx2 ownBool2;
    public boolx4 ownBool4;
    public bool Bool_4;
    public GameObject prefab_cube;
    private void FixedUpdate()
    {

        if (ownBool1.Bool_1 || ownBool2.Bool_2)
        {
            
            Bool_4 = true;
            prefab_cube.GetComponent<Renderer>().material.color = Color.green;
        }


        else
        {
            Bool_4 = false;
            prefab_cube.GetComponent<Renderer>().material.color = Color.gray;
        }
    }
}
