using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    //int x;
    // Start is called before the first frame update
    /// <summary>
    /// Inicializar cualquier objeto
    /// </summary>
    void Start()
    {
        //x = 0;
        ////Formas de imprimir en consola 
        //print("Funciona para imprimir en consola");
        
        ////Log de error
        //Debug.LogError("Algo salio mal");
        ////Log de warning
        //Debug.LogWarning("Algo salio medianamente mal");
    }

    // Update is called once per frame
    /// <summary>
    /// Realizar cualquier calculo que pase en cualquier frame 
    /// Calculo de posiciones de x-y-z
    /// </summary>
    void Update()
    {
        //x++;
        ////Log de informacion
        //Debug.Log("Algo paso - Update"+x);

        Debug.Log("Hola desde update");
    }
    private void FixedUpdate()
    {
        //Log de informacion
        Debug.Log("Hola desde update");

    }
    private void LateUpdate()
    {
        Debug.Log("Hola desde LateUpdate");

    }
    private void OnEnable()
    {
        Debug.Log("Hola desde OnEnable objeto habilitado");

    }
    private void OnDisable()
    {
        Debug.Log("Hola desde OnDisable objeto deshabilitado");
    }
}
