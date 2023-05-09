using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script5 : MonoBehaviour
{
    public Script1 script1;
    public Script2 script2;
    public Script3 Script3;
    public Script4 Script4;
    GameObject go5;

    private void Awake()
    {
        if (script1.ownBool1 == true)
        {
            Renderer rend = go5.GetComponent<Renderer>();
            rend.material.color = Color.blue;
            script1.ownBool1 = false;
        }
        else if (script2.ownBool2 == true)
        {
            Renderer rend = go5.GetComponent<Renderer>();
            rend.material.color = Color.yellow;

            script2.ownBool2 = true;
        }
        else if (Script3.ownBool3 == true)
        {
            Renderer rend = go5.GetComponent<Renderer>();
            rend.material.color = Color.red;

            Script3.ownBool3 = true;
        }
        else if (Script4.ownBool4 == true)
        {
            Renderer rend = go5.GetComponent<Renderer>();
            rend.material.color = Color.gray;

            Script4.ownBool4 = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (script1.ownBool1 == true)
        {
            Renderer rend = go5.GetComponent<Renderer>();
            rend.material.color = Color.blue;
            script1.ownBool1 = false;
        }
        else if (script2.ownBool2 == true)
        {
            Renderer rend = go5.GetComponent<Renderer>();
            rend.material.color = Color.yellow;
         
            script2.ownBool2 = true;
        }
        else if (Script3.ownBool3 == true)
        {
            Renderer rend = go5.GetComponent<Renderer>();
            rend.material.color = Color.red;

            Script3.ownBool3 = true;
        }
        else if (Script4.ownBool4 == true)
        {
            Renderer rend = go5.GetComponent<Renderer>();
            rend.material.color = Color.gray;

            Script4.ownBool4 = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
