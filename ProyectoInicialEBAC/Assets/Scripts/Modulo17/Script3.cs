using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour
{
    public bool ownBool3 = true;
    public Script1 script1;
    public Script2 script2;
    GameObject go3;
    private void Awake()
    {
        if (script1.ownBool1 == true)
        {
            Renderer rend = go3.GetComponent<Renderer>();
            rend.material.color = Color.blue;
            script1.ownBool1 = false;
        }
        else if (script1.ownBool1 == true)
        {
            Renderer rend = go3.GetComponent<Renderer>();
            rend.material.color = Color.yellow;
            Destroy(go3);
            script1.ownBool1 = true;
        }
        else if (script2.ownBool2 == true)
        {
            Renderer rend = go3.GetComponent<Renderer>();
            rend.material.color = Color.red;
            Destroy(go3);
            script1.ownBool1 = true;
        }
        else if (script2.ownBool2 == true)
        {
            Renderer rend = go3.GetComponent<Renderer>();
            rend.material.color = Color.gray;
            Destroy(go3);
            script1.ownBool1 = true;
        }
    }
    // Start is called before the first frame update
    public void Start()
    {
        if(script1.ownBool1 == true)
        {
            Renderer rend = go3.GetComponent<Renderer>();
            rend.material.color = Color.blue;
            script1.ownBool1 = false;
        }
        else if (script1.ownBool1 == true)
        {
            Renderer rend = go3.GetComponent<Renderer>();
            rend.material.color = Color.yellow;
            Destroy(go3);
            script1.ownBool1 = true;
        }
        else if (script2.ownBool2 == true)
        {
            Renderer rend = go3.GetComponent<Renderer>();
            rend.material.color = Color.red;
            Destroy(go3);
            script1.ownBool1 = true;
        }
        else if (script2.ownBool2 == true)
        {
            Renderer rend = go3.GetComponent<Renderer>();
            rend.material.color = Color.gray;
            Destroy(go3);
            script1.ownBool1 = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
}
