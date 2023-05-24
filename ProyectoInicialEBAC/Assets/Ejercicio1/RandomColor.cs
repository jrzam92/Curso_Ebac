using UnityEngine;

public class RandomColor : MonoBehaviour
{


  
    private void OnEnable()
    {
        Color color = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = color;
    }
}
