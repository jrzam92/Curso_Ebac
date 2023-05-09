using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script4 : MonoBehaviour
{
    public Script3 script3;
    public bool ownBool4 = false;
    GameObject go4;
    private void Awake()
    {
        if (script3.ownBool3 == true)
        {
            Renderer rend = go4.GetComponent<Renderer>();
            rend.material.color = Color.blue;
            script3.ownBool3 = false;
        }
        else if (script3.ownBool3 == true)
        {
            Renderer rend = go4.GetComponent<Renderer>();
            rend.material.color = Color.yellow;
            script3.ownBool3 = true;
        }
        else if (ownBool4 == true)
        {
            Renderer rend = go4.GetComponent<Renderer>();
            rend.material.color = Color.red;
            ownBool4 = true;
        }
        else if (ownBool4 == true)
        {
            Renderer rend = go4.GetComponent<Renderer>();
            rend.material.color = Color.gray;
            ownBool4 = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (script3.ownBool3 == true)
        {
            Renderer rend = go4.GetComponent<Renderer>();
            rend.material.color = Color.blue;
            script3.ownBool3 = false;
        }
        else if (script3.ownBool3 == true)
        {
            Renderer rend = go4.GetComponent<Renderer>();
            rend.material.color = Color.yellow;
            script3.ownBool3 = true;
        }
        else if (ownBool4 == true)
        {
            Renderer rend = go4.GetComponent<Renderer>();
            rend.material.color = Color.red;
            ownBool4 = true;
        }
        else if (ownBool4 == true)
        {
            Renderer rend = go4.GetComponent<Renderer>();
            rend.material.color = Color.gray;
            ownBool4 = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
