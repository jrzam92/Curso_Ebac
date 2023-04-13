using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public bool ownBool1 = true;
    GameObject n_cube1;
    GameObject prefab_cube;

    /// <summary>
    /// Consturctor para poder usarlo en otros scripts 
    /// </summary>
    public Script1()
    {
          
    }
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

        if (ownBool1)
        {
            //GO1
            n_cube1 = Instantiate(prefab_cube);
            Renderer rend = n_cube1.GetComponent<Renderer>();
            rend.material.color = Color.white;
            ownBool1=false;
        }
        
    }
}
