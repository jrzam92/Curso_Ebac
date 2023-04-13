using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnerMod7 : MonoBehaviour
{
    //Variable boolena
    bool isFixUpdateMethod = false;
    //Variables de GO1......GO2
    GameObject n_cube1, n_cube2,n_cube3;
    GameObject prefab_cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        
        if (isFixUpdateMethod)
        {
            //GO1
            n_cube1 = Instantiate(prefab_cube); 
            Renderer rend = n_cube1.GetComponent<Renderer>(); 
            rend.material.color = Color.white;

            //GO2
            n_cube2 = Instantiate(prefab_cube); 
            Renderer render = n_cube2.GetComponent<Renderer>(); 
            rend.material.color = Color.white;
        }
        else
        {
            //GO1
            n_cube1 = Instantiate(prefab_cube); 
            Renderer rend = n_cube1.GetComponent<Renderer>(); 
            rend.material.color = Color.black;
            //GO2
            n_cube2 = Instantiate(prefab_cube); 
            Renderer render = n_cube2.GetComponent<Renderer>(); 
            rend.material.color = Color.white;
        }
    }
}
