using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    public int by_frame = 0;
    public float by_fu_frame = 0f;
    public string parImpar;
    float v1 = 0f,v2=0f;
    int res = 0;
    private void Update()
    {
        //Incremento de by_frame 
        by_frame += 1;
        //print(by_frame);
    }
    private void FixedUpdate()
    {
        //incremento de variable dentro del metodo fixed 
        by_fu_frame += by_frame;
        //print(by_frame);

        //Casteo explicito
        v1 = 15;
        v2 = 6;
        res = (int)(v1 / v2);
        switch (parImpar.ToLower()) {
            case "par" when by_frame % 2 == 0:
                
                    //print(string.Format($"el valor {by_frame} es par"));
                    GetComponent<MeshRenderer>().material.color = Color.red;
                
                break;
            case "impar" when by_frame % 2 == 1:
                
                    //print(string.Format($"el valor {by_frame} es impar"));
                    GetComponent<MeshRenderer>().material.color = Color.green;
                
                break;
        }
        float pi = 3.14159f;
        string str_pi = string.Format($"El numero pi a 4 decimales {pi.ToString("F4")} con presicion");

        string fullname = "Jose Raul Zamora Villaseñor";
        string name = fullname.Substring(0, 4).Trim();
        string middlename = fullname.Substring(4, 6).Trim();
        string lastname = fullname.Substring(9);
        string[] arrayName=fullname.Split(' ');
        List<string> list = new List<string>(); 
        list.Add(name);
        list.Add(middlename);
        list.Add(lastname);

        foreach(var item in list)
        {
            print(item);
        }

        string numero1 = "14785";
        string numero2 = "75863";

        int valor1;
        int valor2;

        if (int.TryParse(numero1, out valor1) && int.TryParse(numero2, out valor2))
        {
            int resultado = valor1 + valor2;
            //print("El resultado de la suma es: " + resultado);
        }
        else
        {
            //print("No se pudo convertir uno o ambos números.");
        }

        string oracion = "Hola Mundo";

        for (int i = 0; i < oracion.Length; i++)
        {
            if (i % 2 == 0)
            {
                print(oracion[i]);
            }
        }

        string oracion2 = "Que la fuerza te acompañe";
        string oracion2substring = oracion2.Substring(5);
        string oracion2Remove = oracion2.Remove(0,5);
    }
}
