using UnityEngine;
using System.Collections;

public class ControladorItensColetaveis : MonoBehaviour {

    public GameObject Personagem;
    public GameObject Coins;

    // Use this for initialization
    void Start () {
        Personagem = GameObject.FindGameObjectWithTag("Personagem");
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    void interacao()
    {
        Instantiate(Coins);
        Personagem.GetComponent<ControladorPersonagem>().Coins += 1;
        Destroy(this.gameObject);
    }
}
