using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script5 : MonoBehaviour
{

    public boolx3 ownBool3;
    public boolx4 ownBool4;
    private bool ownBool5;
    public GameObject prefab_cube;
    private void FixedUpdate()
    {


        if (ownBool3.Bool_3 || ownBool4.Bool_4)
        {
             
            ownBool5 = true;
            prefab_cube.GetComponent<Renderer>().material.color = Color.green;
        }


        else if (ownBool3.Bool_3 && ownBool4.Bool_4)
        {
            ownBool5 = false;
            prefab_cube.GetComponent<Renderer>().material.color = Color.gray;
        }



    }
}
