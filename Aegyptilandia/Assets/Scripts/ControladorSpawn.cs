using UnityEngine;
using System.Collections;

public class ControladorSpawn : MonoBehaviour
{

    public GameObject prefabMosquito;


    public int secChange;
    private float timechange;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Instancia Prefab do Mosquito entre timechange segundos
        timechange += Time.deltaTime;
        if (timechange >= secChange)
        {
            Instantiate(prefabMosquito);
            timechange = 0;
        }
    }
}
