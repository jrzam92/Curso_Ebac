using UnityEngine;
using UnityEngine.UI;

public class NumeroDeVeces : MonoBehaviour
{
    public int VecesQueInstancian = 0;
    public Text textoNum;
    

    private void Start()
    {

        textoNum.text =$"{VecesQueInstancian}" ;
    }

    private void Update()
    {

        textoNum.text= $"{VecesQueInstancian}";
    }
}
