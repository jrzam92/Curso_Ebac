
using Unity.VisualScripting;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    public GameObject prefabNumVeces;
    GameObject _prefabNumVeces;
    public GameObject prefabLeft;
    public GameObject prefabRight;
    GameObject cubeRight;
    GameObject cubeLeft;
    public int randomPos = 0;

    public Vector3 Pos1 = new Vector3(-6, 0, 0);
    public Vector3 Pos2 = new Vector3(6, 0, 0);
    public Vector3 NewPos;

    public Color ColorDerecho = Color.cyan;
    public Color ColorIzquierdo= Color.magenta;


    private void Update()
    {
        this._prefabNumVeces = Instantiate(prefabNumVeces);
      
         RandomColor randomColor = new RandomColor();
        



        if (Input.GetKey(KeyCode.RightArrow)) //condicion cuando se presiona la tecla Derecha
        {

            prefabNumVeces.GetComponent<NumeroDeVeces>().VecesQueInstancian += 1;
            if (prefabNumVeces.GetComponent<NumeroDeVeces>().VecesQueInstancian == 5)
            {
                print($"Verdadero valor :   {prefabNumVeces.GetComponent<NumeroDeVeces>().VecesQueInstancian}");
            }
            else
            {
                print($"Falso valor :   {prefabNumVeces.GetComponent<NumeroDeVeces>().VecesQueInstancian}");
            }
            this.cubeRight = Instantiate(prefabRight);
            this.cubeRight.transform.position = new Vector3(3.83f, 1.87f, 7.27f);
            this.cubeRight.transform.localScale = new Vector3(.5f, .5f, .5f);
            this.cubeRight.GetComponent<Renderer>().material.color = Color.red;
            //randomColor.ChangeRandomColor(this.cubeRight, ColorDerecho);
            randomPos = Random.Range(1, 3);
            
            switch (randomPos)
            {
                case 1:
                    this.cubeRight.transform.position = Pos1;
                    break;
                case 2:
                    this.cubeRight.transform.position = Pos2;
                    break;
            }


        }
        else if (Input.GetKey(KeyCode.LeftArrow)) //condicion cuando se presiona la tecla Izquierda
        {


            prefabNumVeces.GetComponent<NumeroDeVeces>().VecesQueInstancian -= 1;
            if (prefabNumVeces.GetComponent<NumeroDeVeces>().VecesQueInstancian == 5)
            {
                print("Verdadero valor : " + prefabNumVeces.GetComponent<NumeroDeVeces>().VecesQueInstancian);
            }
            else
            {
                print("Falso valor : " + prefabNumVeces.GetComponent<NumeroDeVeces>().VecesQueInstancian);
            }
            this.cubeLeft =Instantiate(prefabLeft);
            this.cubeLeft.transform.position = new Vector3(-2.42f, 2.1f, 14.67f);
            this.cubeLeft.transform.localScale= new Vector3(.5f, .5f, .5f);
             
            randomColor.ChangeRandomColor(this.cubeLeft, ColorIzquierdo);
            randomPos = Random.Range(1, 3);
            
            switch (randomPos)
            {
                case 1:
                    this.cubeLeft.transform.position = Pos1;
                    break;
                case 2:
                    this.cubeLeft.transform.position = Pos2;
                    break;
            }
        }
    }
}
