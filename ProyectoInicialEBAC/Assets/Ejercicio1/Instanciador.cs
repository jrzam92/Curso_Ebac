
using UnityEngine;

public class Instanciador : MonoBehaviour
{
   

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
        //Variables para poder realizar el movimiento en el canvas 
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        //Variable para poder dar direccion entre el eje x y el eje y 
        Vector2 direccion = new Vector2(x, y);
        //Se ocupa para mandar directamente el objeto que se esta usando el mismo script 
        GetComponent<Rigidbody>().velocity = new Vector2(direccion.x * velocidadMov, direccion.y * velocidadMov);

        randomPos = Random.Range(1, 2);
        print(randomPos);
        switch (randomPos)
        {
            case 1:
                GetComponent<Rigidbody>().transform.position = Pos1;
                break;
            case 2:
                GetComponent<Rigidbody>().transform.position = Pos2;
                break;
        }

        if (Input.GetKey(KeyCode.RightArrow)) //condicion cuando se presiona la tecla Derecha
        {
           
           GetComponent<Renderer>().material.color = ColorDerecho;
            if (direccion.x < 0) //si direccion x es menor a 0 realiza lo siguiente
            {
                //el objeto se mueve a la derecha 
                transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
                isRight = false;
            }
            randomPos += 1;
            print(randomPos);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) //condicion cuando se presiona la tecla Izquierda
        {
            if (direccion.x > 0)//si direccion x es mayor a 0 realiza lo siguiente
            {
                //el objeto se mueve a la izquierda
                transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y);
                isLeft = false;
            }
            //forma en la que se puede cambiar el color del propio objeto   
            GetComponent<Renderer>().material.color = ColorIzquierdo;
            randomPos += 1;
            print(randomPos);
        }
    }
}
