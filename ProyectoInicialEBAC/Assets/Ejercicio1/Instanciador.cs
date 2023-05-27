
using Unity.VisualScripting;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
   

    public int randomPos = 0;

    public Vector3 Pos1 = new Vector3(-6, 0, 0);
    public Vector3 Pos2 = new Vector3(6, 0, 0);
    public Vector3 NewPos;

    public Color ColorDerecho = Color.cyan;
    public Color ColorIzquierdo= Color.magenta;


    private void Update()
    {
        //Variables para poder realizar el movimiento en el canvas 
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        
         
       
        //randomPos = Random.Range(1, 2);
        //print(randomPos);
        //switch (randomPos)
        //{
        //    case 1:
        //        transform.position = Pos1;
        //        break;
        //    case 2:
        //        transform.position = Pos2;
        //        break;
        //}

        if (Input.GetKey(KeyCode.RightArrow)) //condicion cuando se presiona la tecla Derecha
        {
           
            GameObject cubeRight = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubeRight.transform.position = new Vector3(3.83f, 1.87f, 7.27f);
            cubeRight.transform.localScale = new Vector3(.5f, .5f, .5f);
            cubeRight.GetComponent<Renderer>().material.color = Color.red;

           GetComponent<Renderer>().material.color = ColorDerecho;
            

        }
        else if (Input.GetKey(KeyCode.LeftArrow)) //condicion cuando se presiona la tecla Izquierda
        {



            GameObject cubeLeft = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubeLeft.transform.position = new Vector3(-2.42f, 2.1f, 14.67f);
            cubeLeft.transform.localScale= new Vector3(.5f, .5f, .5f);
            cubeLeft.GetComponent<Renderer>().material.color = Color.blue;
            //forma en la que se puede cambiar el color del propio objeto   
            GetComponent<Renderer>().material.color = ColorIzquierdo;
             
        }
    }
}
