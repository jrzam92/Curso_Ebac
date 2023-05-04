using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    public bool ownBool2 = false;
    GameObject go2;
    public GameObject prefab_cube2;
    private void Awake()
    {
        print("entro a script 2 ");
        //go = Resources.Load("cb1") as GameObject;
        go2 = Instantiate(prefab_cube2);
        if (ownBool2)
        {

            Renderer rend = go2.GetComponent<Renderer>();
            rend.material.color = Color.blue;
            Destroy(go2);
            ownBool2 = false;
        }
        else
        {

            Renderer rend = go2.GetComponent<Renderer>();
            rend.material.color = Color.yellow;
            Destroy(go2);
            ownBool2 = true;
        }
    }
    private void FixedUpdate()
    {

        print("entro a script 2 ");
        //go = Resources.Load("cb1") as GameObject;
        go2 = Instantiate(prefab_cube2);
        if (ownBool2)
        {

            Renderer rend = go2.GetComponent<Renderer>();
            rend.material.color = Color.blue;
            ownBool2 = false;
        }
        else
        {

            Renderer rend = go2.GetComponent<Renderer>();
            rend.material.color = Color.yellow;
            ownBool2 = true;
        }

    }
}
