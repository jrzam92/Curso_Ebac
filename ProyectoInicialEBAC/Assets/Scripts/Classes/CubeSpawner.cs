using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    GameObject go; //Objeto vacio para la instancia del prefab
    GameObject objtoSpawn;
    Vector3[] vertices = {
    new Vector3(0,0,0),//Vertice 0
    new Vector3(1,0,0),//Vertice 1
    new Vector3(1,1,0),//Vertice 2
    new Vector3(0,1,0),//Vertice 3
    new Vector3(0,1,1),//Vertice 4
    new Vector3(1,1,1),//Vertice 5
    new Vector3(1,0,1),//Vertice 6
    new Vector3(0,0,1) //Vertice 7


    };

    int[] tringulos = {
        0,2,1,//Cara 1 
        0,3,2,
        2,3,4,//Cara 2
        2,4,5,
        1,2,5,//Cara 3
        1,5,6,
        0,7,4,//Cara 4
        0,4,3,
        5,4,7,//Cara 5
        5,7,6,
        0,6,7,//Cara 6
        0,1,6
    };
    public GameObject prefabCubo;
    public List<GameObject> lstCubes;
    public float factorEscalamiento;
    public int numCubos = 0;

    private void Awake()
    {
        //Se instancia el objeto GamObject para el prefab 
        go = Instantiate(prefabCubo);
        //Se inicializa el renderizado para el objeto gameobject 
        Renderer rend = go.GetComponent<Renderer>();
        //Se realiza el cambio de color 
        rend.material.color = Color.blue;

        print("Desde Awake");

    }
    // Start is called before the first frame update
    void Start()
    {
         lstCubes = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        //GenerateCubes();
    }
    public void SetCube()
    {
        objtoSpawn = new GameObject("CuboCode");
        objtoSpawn.AddComponent<MeshFilter>();
        var meshFilter = objtoSpawn.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = tringulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();//Mejora en el renderizado
        objtoSpawn.AddComponent<BoxCollider>();
        var boxCollider = objtoSpawn.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        objtoSpawn.AddComponent<MeshRenderer>();
        var meshRendererMaterial = objtoSpawn.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = Color.white;
        objtoSpawn.transform.position = Vector3.one;
    }
    public void GenerateCubes() {
        //Cada cubo se ejecuta cada frame 
        numCubos++;
        //Inicializar el prefab
        GameObject tempGameObject = Instantiate(prefabCubo);
        //Nombre de tag para el prefab
        tempGameObject.name = "CuboNumero" + numCubos;
        Color color = new Color(Random.value, Random.value, Random.value);
        //Se agrega el color al prefab
        tempGameObject.GetComponent<MeshRenderer>().material.color = color;
        tempGameObject.transform.position = Random.insideUnitSphere;
        //Se agrega a una lista el componente de prefabs
        lstCubes.Add(tempGameObject);
        List<GameObject> lstObjPrefabsEliminar = new List<GameObject>();
        foreach (GameObject p_cube in lstCubes)
        {

            //Obtener el escalamiento
            float scale = p_cube.transform.localScale.x;
            scale *= factorEscalamiento;
            p_cube.transform.localScale = Vector3.one * scale;
            //Cuando sea la escala menor o igual a 0.1 se agregaran los prefabs a la lista
            if (scale <= 0.1)
            {
                lstObjPrefabsEliminar.Add(p_cube);
            }
        }
        foreach (GameObject p_cube in lstObjPrefabsEliminar)
        {
            lstObjPrefabsEliminar.Remove(p_cube);
            Destroy(p_cube);
        }
    }
    private void OnEnable()
    {
        go = Instantiate(prefabCubo);
        Renderer rend = go.GetComponent<Renderer>();
        rend.material.color = Color.green;

    }
    private void OnDisable()
    {
        go = Instantiate(prefabCubo);
        Renderer rend = go.GetComponent<Renderer>();
        rend.material.color = Color.yellow;
    }
}
