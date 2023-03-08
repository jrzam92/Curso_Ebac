using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente1 : MonoBehaviour
{
    //Inicializacion de variable de un objeto(cubo/personaje)
    public static GameObject miObjeto;
    /// <summary>
    /// Se ejecuta antes de start esto es para instanciar el script 
    /// </summary>
    private void Awake()
    {
        print("awake en Componente1");
        miObjeto = this.gameObject;
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
