using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BorradorAltura : MonoBehaviour
{
    
    private void FixedUpdate()
    {
        if (GetComponent<Rigidbody>().position.y <= -6)
        {
            Destroy(this);
        }
    }
}
