using UnityEngine;

public class RandomColor : MonoBehaviour
{


    public GameObject prefabGO;
    private void OnEnable()
    {
        Color color = new Color(Random.value, Random.value, Random.value);
        prefabGO.GetComponent<Renderer>().material.color = color;
    }
}
