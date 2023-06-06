using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class ExCiclosArreglos : MonoBehaviour
{
    
    private void FixedUpdate()
    {
        //ejercicio1();
        //ejercicio2();
        ejercicio3();
    }


    /// <summary>
    /// crea dos arreglos unidimensionales de numeros enteros y llenalos usando un ciclo y la funcion random.range,
    /// despues crear un tercer arreglo y llenarlo con la suma de los elementos de los primeros dos
    /// </summary>
    public void ejercicio1()
    { 
        GetComponent<MeshRenderer>().material.color = Color.red;
        int size = 5;
         
        int[] arreglo1 = new int[size];
        int[] arreglo2 = new int[size];
         
       var  random = UnityEngine.Random.Range(1,10);
        for (int i = 0; i < size; i++)
        {
            arreglo1[i] = random;  
            arreglo2[i] = random; 
        } 
        int[] resultado = new int[size];
         
        for (int i = 0; i < size; i++)
        {
            resultado[i] = arreglo1[i] + arreglo2[i];
        } 
        print("Arreglo 1:");
        printArray(arreglo1);

        print("Arreglo 2:");
        printArray(arreglo2);

        print("Arreglo resultado:");
        printArray(resultado);
    }

    
    static void printArray(int[] arreglo)
    {
        foreach (int elemento in arreglo)
        {
            print(elemento + " ");
            Console.WriteLine(elemento + " ");
        }
       
    }
    /// <summary>
    /// Crea un arreglo de strings y llena cada elemnto con una palabra de una oracion despues utilizando un ciclo foreach 
    /// concatena sus elementos e imprime la oracion completa en la consola en un solo string
    /// </summary>
    public void ejercicio2()
    {
        GetComponent<MeshRenderer>().material.color = Color.yellow;
        string oracion = "Que la fuerza te acompañe !!!, Star wars";


        string[] palabras = oracion.Split(' ');


        string oracionCompleta = "";
        foreach (string palabra in palabras)
        {
            oracionCompleta += palabra+" ";
        
        } 
        print(oracionCompleta);
    }



    /// <summary>
    /// Crea un arreglo  bidimesional en c sharp de enteros de 2 renglones y 3 columnas al menos y multiplica
    /// por un arreglo unidimensional de enteros con la cantidad de elementos que se alinee a la cantidad de renglones
    /// del arreglo bidimensional de tal manera que la operacion sea una una multiplicacion matriz * vector que da como
    /// resultado un arreglo unidimensional 
    /// </summary>
    public void ejercicio3()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
        int[,] matriz = new int[2,2]
        {
            { 1, 2 },
            { 4, 5 }
        };

        
        int[] vector = new int[2] { 2, 3};

        var res1 = matriz[0, 0] * vector[0] + matriz[0, 1] * vector[1];
        var res2 = matriz[1, 0] * vector[0] + matriz[1, 1] * vector[1];

        print (res1);
        print (res2);

    }
}
