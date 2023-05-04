using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public bool ownBool1 = true;
     GameObject go;
    public GameObject prefab_cube;
    private void Awake()
    {
        print("entro a script 1 ");
        go = Resources.Load("cb1") as GameObject;
        go=Instantiate(prefab_cube);
        if (ownBool1)
        {

            Renderer rend = go.GetComponent<Renderer>();
            rend.material.color = Color.black;
            ownBool1 = false;
        }
        else
        {

            Renderer rend = go.GetComponent<Renderer>();
            rend.material.color = Color.yellow;
            ownBool1 = true;
        }
    }
    private void Start()
    {
        if (ownBool1)
        {
            //GO1
            go = Instantiate(prefab_cube);
            Renderer rend = go.GetComponent<Renderer>();
            rend.material.color = Color.white;
            ownBool1 = false;
        }
        else
        {
            go = Instantiate(prefab_cube);
            Renderer rend = go.GetComponent<Renderer>();
            rend.material.color = Color.black;
            ownBool1 = true;
        }
    }
    private void Update()
    {
        if (ownBool1)
        {
            //GO1
            go = Instantiate(prefab_cube);
            Renderer rend = go.GetComponent<Renderer>();
            rend.material.color = Color.white;
            ownBool1 = false;
        }
        else
        {
            go = Instantiate(prefab_cube);
            Renderer rend = go.GetComponent<Renderer>();
            rend.material.color = Color.black;
            ownBool1 = true;
        }
    }
    private void FixedUpdate()
    {

        if (ownBool1)
        {
            //GO1
            go = Instantiate(prefab_cube);
            Renderer rend = go.GetComponent<Renderer>();
            rend.material.color = Color.white;
            ownBool1 = false;
        }
        else
        {
            go = Instantiate(prefab_cube);
            Renderer rend = go.GetComponent<Renderer>();
            rend.material.color = Color.black;
            ownBool1 = true;
        }

    }
}
