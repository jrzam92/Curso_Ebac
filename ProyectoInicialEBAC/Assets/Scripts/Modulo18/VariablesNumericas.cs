using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesNumericas : MonoBehaviour
{
    sbyte miByteConSigno = 0;
    byte miByte = 0;
    short miShort = 1;
    ushort miUShortSinSigno = 0;
    int miInt= 0;
    uint miIntSinSigno = 0;
    long miLong=0;
    ulong miLongSinSigno = 0;
    // Start is called before the first frame update
    void Start()
    {
        miByteConSigno = -25;
        miInt = miByteConSigno;
        Debug.Log("el valor de miByteConSigno es: " + miByteConSigno);
        miByte = 200;
        miIntSinSigno = miByte;
        miIntSinSigno=(uint)miByteConSigno;
        Debug.Log("el valor de miIntSinSigno es: " + miIntSinSigno);

        miLong=long.MaxValue;
        miInt =(int) miLong;
        Debug.Log("el valor de miInt es: " + miInt);

        int a, b,c;
        a = 5;b = 10;
        c = a + b;
        Debug.Log(c);
        c = a - b;
        Debug.Log(c);
        c = a * b;
        Debug.Log(c);
        c = a / b;
        Debug.Log(c);

        float z, x, v;
        z = 5; x = 10;
        v = z + x;
        Debug.Log(v);
        v = z - x;
        Debug.Log(v);
        v = z * x;
        Debug.Log(v);
        v = z / x;
        Debug.Log(v);

    }

    // Update is called once per frame
    void Update()
    {
        miShort += 3;
        Debug.Log(miShort); 
    }
}
