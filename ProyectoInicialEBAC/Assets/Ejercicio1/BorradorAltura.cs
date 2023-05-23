using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BorradorAltura : MonoBehaviour
{
    public GameObject prefabGO;
    private void FixedUpdate()
    {
        if (prefabGO.GetComponent<Rigidbody>().position.y <= -6)
        {
            Destroy(prefabGO);
        }
    }
}
