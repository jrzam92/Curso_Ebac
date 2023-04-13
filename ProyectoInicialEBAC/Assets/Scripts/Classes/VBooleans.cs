using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VBooleans : MonoBehaviour
{
    //Por defecto las variables tienen valor de falso
    //variables booleanas
    bool var1;
    bool var2;
    bool var3;
    //variables numericas
    int val1 = 5;
    int limiteInferior = 0;
    int limiteSuperior = 5;// numero 6 no es valido por lo que toma el valor por default de switch


    enum SeleccionarColor
    { 
        rojo,
        verde,
        azul,
        blanco,
        gris
    }
    
    // Start is called before the first frame update
    void Start()
    {
        var1 = true;
        var2 = false;

        if (var1) {
            Debug.Log("Esta variable 1 es verdadera");
            Debug.Log("ya tienes el valor de variable 1");
        } 
        if (val1 == 5) {
            Debug.Log("Valor de variable es 5");
        }
        /*
             * BINARIOS 
             * 1 = TRUE
             * 0 = FALSE
             A B C  OR  AND  ((A or B) and C) ((A or B) or C)
             1 1 1      
             1 0 1      
             0 1 1      
             0 0 1 
             0 1 1
             0 1 0
             1 0 0
             0 0 0
        */
        /*
         * Se realiza ejercicio con operador or
         */
        bool a = false,b=false,c=false;
        // 1 1 1
        a = true;b= true;c = true;
        if (a || b || c)
        {
            print("Variable a-> "+a+" || b-> "+b +" || c-> "+c);

        }
        //1 0 1 
        a = true;b = false;c = true;
        if (a || b || c)
        {
            print("Variable a-> " + a + " || b-> " + b + " || c-> " + c);
        }
        //0 0 1 
        a = false; b = false; c = true;
        if (a || b || c)
        {
            print("Variable a-> " + a + " || b-> " + b + " || c-> " + c);
        }
        //0 1 1
        a = false; b = true; c = true;
        if (a || b || c)
        {
            print("Variable a-> " + a + " || b-> " + b + " || c-> " + c);
        }
        // 0 1 0
        a = false; b = true; c = false;
        if (a || b || c)
        {
            print("Variable a-> " + a + " || b-> " + b + " || c-> " + c);
        }
        //1 0 0
        a = true; b = false; c = false;
        if (a || b || c)
        {
            print("Variable a-> " + a + " || b-> " + b + " || c-> " + c);
        }
        // 0 0 0
        a = false; b = false; c = false;
        if (a || b || c)
        {
            print("Variable a-> " + a + " || b-> " + b + " || c-> " + c);
        }
        /*
         * Se realiza ejercicio con operador and
         */
        a = true; b = true; c = true;
        if (a && b && c)
        {
            print("Variable a-> " + a + " && b-> " + b + " && c-> " + c);

        }
        //1 0 1 
        a = true; b = false; c = true;
        if (a && b && c)
        {
            print("Variable a-> " + a + " && b-> " + b + " && c-> " + c);
        }
        //0 0 1 
        a = false; b = false; c = true;
        if (a && b && c)
        {
            print("Variable a-> " + a + " && b-> " + b + " && c-> " + c);
        }
        //0 1 1
        a = false; b = true; c = true;
        if (a && b && c)
        {
            print("Variable a-> " + a + " && b-> " + b + " && c-> " + c);
        }
        // 0 1 0
        a = false; b = true; c = false;
        if (a && b && c)
        {
            print("Variable a-> " + a + " && b-> " + b + " && c-> " + c);
        }
        //1 0 0
        a = true; b = false; c = false;
        if (a && b && c)
        {
            print("Variable a-> " + a + " && b-> " + b + " && c-> " + c);
        }
        // 0 0 0
        a = false; b = false; c = false;
        if (a && b && c)
        {
            print("Variable a-> " + a + " && b-> " + b + " && c-> " + c);
        }

        val1 = Random.Range(limiteInferior, limiteSuperior);
        print(val1);
        bool isRed = true;
        switch(val1)
        {
            case (int)SeleccionarColor.rojo when isRed==true: //se puede agregar condicionantes con un when
                print("Se selecciono el color rojo");
                break;
            case (int)SeleccionarColor.verde:
                print("Se selecciono el color rojo");
                break;
            case (int)SeleccionarColor.azul:
                print("Se selecciono el color rojo");
                break;
            case (int)SeleccionarColor.blanco:
                print("Se selecciono el color rojo");
                break;
            case (int)SeleccionarColor.gris:
                print("Se selecciono el color rojo");
                break;
            default:
                print("Ese valor no existe !!! y no es valido ... xD");
            break;
        }
        //Operador ternario
        string colorRes = (isRed == true) ? "El color sera rojo" : "El color no es rojo";
        print(colorRes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
