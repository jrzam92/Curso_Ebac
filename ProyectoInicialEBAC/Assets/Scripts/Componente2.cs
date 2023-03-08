using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente2 : MonoBehaviour
{
    /// <summary>
    /// Se ejecuta antes de start
    /// </summary>
    private void Awake()
    {
        print("awake en Componente2");
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Componente1.miObjeto.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
