
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    public GameObject prefabGO;

    public int randomPos = 0;

    public Vector3 Pos1 = new Vector3(-6, 0, 0);
    public Vector3 Pos2 = new Vector3(6, 0, 0);
    public Vector3 NewPos;

    public Color ColorDerecho = Color.cyan;
    public Color ColorIzquierdo= Color.magenta;


    public bool isLeft = true;
    public bool isRight = true;
    public float velocidadMov = 10;

    private void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 direccion = new Vector2(x, y);
        prefabGO.GetComponent<Rigidbody>().velocity = new Vector2(direccion.x * velocidadMov, direccion.y * velocidadMov);
        print(direccion.y);
        if (direccion != Vector2.zero)
        {
            
            if (direccion.x < 0 && transform.localScale.x > 0 && isLeft)
            {
                transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
                isRight = false;
            }
            else if (direccion.x > 0 && transform.localScale.x < 0 && isRight)
            {
                transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y);
                isLeft = false;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow)) //Derecha
        {
            prefabGO.GetComponent<Renderer>().material.color = ColorDerecho;
            
            randomPos += 1;
            print(randomPos);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) //Izquierda
        {
            prefabGO.GetComponent<Renderer>().material.color = ColorIzquierdo;
            randomPos += 1;
            print(randomPos);
        }
    }
}
