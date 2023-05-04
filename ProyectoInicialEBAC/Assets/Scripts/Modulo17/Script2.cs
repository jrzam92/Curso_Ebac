using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    public bool ownBool2 = false;
    GameObject go;
    public GameObject prefab_cube;
    
    private void FixedUpdate()
    {

        print("entro a script 1 ");
        go = Resources.Load("cb1") as GameObject;
        go = Instantiate(prefab_cube);
        if (ownBool2)
        {

            Renderer rend = go.GetComponent<Renderer>();
            rend.material.color = Color.blue;
            Destroy(go);
            ownBool2 = false;
        }
        else
        {

            Renderer rend = go.GetComponent<Renderer>();
            rend.material.color = Color.yellow;
            Destroy(go);
            ownBool2 = true;
        }

    }
}
