using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EjercicioEstructuras : MonoBehaviour
{
    private void Start()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
        //var numCollectList=NumAletorioList(3, 2, 5);
        //foreach(int item in numCollectList)
        //{
        //    print(item);
        //}
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //var arrayCollectNums = arrayNums(nums);
        //foreach (int item in arrayCollectNums)
        //{
        //    print(item);
        //}

        //List<string> list = new List<string>();
        //var miListHashCollect = miHashCollect(list);
        //foreach (string item in miListHashCollect)
        //{
        //    print(item);
        //}

        miStackQueue();
    }

    /// <summary>
    /// Crea una funcion que reciba como parametros tres numeros, llene una 
    /// lista de numeros aleatorios del tamanio del primer numero y los rangos 
    /// de los numeros aleatorios esten dados por el segundo y tercer parametro
    /// </summary>
    /// <param name="tamanio"></param>
    /// <param name="rangoInFerior"></param>
    /// <param name="rangoSuperior"></param>
    public List<int> NumAletorioList(int tamanio, int rangoInFerior, int rangoSuperior)
    {
        var randomNo = UnityEngine.Random.Range(rangoInFerior, rangoSuperior);
        List<int> list = new List<int>();
        for (int i = 0; i < tamanio; i++)
        {
            list.Add(randomNo);
        }

        return list;
    }

    /// <summary>
    /// Crea una funcion que reciba como entrada un arreglo de eneteros y regrese un arreglo con los 
    /// mismo numeros pero ordenados de manera descendente
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] arrayNums(int[] nums)
    {
        //return nums.OrderByDescending(x => x).ToArray();
        Array.Sort(nums);
        Array.Reverse(nums);
        return nums;

    }
    /// <summary>
    /// Crea una funcion que reciba una lista previamente llena de numeros o strings que contenga 
    /// elementos repetidos y de salida regresa un haset sin elementos repetidos
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public HashSet<string> miHashCollect(List<string> list)
    {
        list.Add("Mario");
        list.Add("Luigi");
        list.Add("Peach");
        list.Add("Bowser");
        list.Add("Mario");
        list.Add("Toad");
        list.Add("Toad");
         
        return list.ToHashSet();
    }

    
    public void miStackQueue()
    {
        Queue queue = new Queue();
        Stack stack = new Stack();
        stack.Push("Goku");
        stack.Push("Vegeta");
        stack.Push("Broli");
        stack.Push("Picoro");
        stack.Push("Gohan");
        foreach (var item in stack)
        {
            queue.Enqueue(item);
        }
        
        foreach (var item in queue)
        {
            print($"Queue ... {item}");
        }
        



    }
}
