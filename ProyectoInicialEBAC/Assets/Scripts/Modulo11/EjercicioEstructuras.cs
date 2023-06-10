using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EjercicioEstructuras : MonoBehaviour
{
    private void Start()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
        int[] nums = {1,2,3,4,5,6,7,8,9 };
        HashSet<string> list = new HashSet<string>();
        //var numCollectList=NumAletorioList(3, 2, 5);
        //foreach(int item in numCollectList)
        //{
        //    print(item);
        //}
        //var arrayCollectNums = arrayNums(nums);
        //foreach (int item in arrayCollectNums)
        //{
        //    print(item);
        //}
        list.Add("Mario");
        list.Add("Luigi");
        list.Add("Peach");
        list.Add("Bowser");
        list.Add("Mario");
        list.Add("Toad");
        list.Add("Toad");
        var miListHashCollect = miHashCollect(list);
        foreach (string item in miListHashCollect)
        {
            print(item);
        }







    }

    /// <summary>
    /// Crea una funcion que reciba como parametros tres numeros, llene una 
    /// lista de numeros aleatorios del tamanio del primer numero y los rangos 
    /// de los numeros aleatorios esten dados por el segundo y tercer parametro
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <param name="num3"></param>
    public List<int> NumAletorioList(int tamanio, int rangoInFerior, int rangoSuperior)
    {
        List<int> list = new List<int>();
        list.Add(tamanio);
        list.Add(rangoInFerior);
        list.Add(rangoSuperior);
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
        return nums.OrderByDescending(x => x).ToArray();
    }
    /// <summary>
    /// Crea una funcion que reciba una lista previamente llena de numeros o strings que contenga 
    /// elementos repetidos y de salida regresa un haset sin elementos repetidos
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public List<string> miHashCollect(HashSet<string> list)
    {
        return list.Distinct().ToList();
    }
}
