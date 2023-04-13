using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    public bool ownBool2 = false;
    GameObject n_cube1;
    GameObject prefab_cube;
    /// <summary>
    /// Consturctor para poder usarlo en otros scripts 
    /// </summary>
    /// <param name="_ownBool1"></param>
    public Script2(bool _ownBool2)
    {
        ownBool2 = _ownBool2;
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

        if (ownBool2)
        {
            //GO1
            n_cube1 = Instantiate(prefab_cube);
            Renderer rend = n_cube1.GetComponent<Renderer>();
            rend.material.color = Color.white;
            ownBool2 = true;
        }
        
    }
}
