using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BorradorAltura : MonoBehaviour
{
    
    private void FixedUpdate()
    {
        if (transform.position.y <= -6)
        {
            Destroy(this.gameObject);
        }
    }
}
