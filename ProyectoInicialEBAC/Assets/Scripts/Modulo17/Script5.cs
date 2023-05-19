using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script5 : MonoBehaviour
{

    public boolx1 ownBool1;
    public boolx2 ownBool2;
    private bool ownBool;
    public GameObject prefab_cube;
    private void FixedUpdate()
    {
        
        
            if(ownBool1)prefab_cube.GetComponent<Renderer>().material.color = Color.green;
            else if(ownBool2)prefab_cube.GetComponent<Renderer>().material.color = Color.red;
               
                 
        
    }
}
