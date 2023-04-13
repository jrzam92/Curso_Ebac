using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour
{
    public bool ownBool3 = false;
    public Script3()
    {
        
    }
    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Script1 script1 = new Script1();
        var bool1=script1.ownBool1;
    }
}
