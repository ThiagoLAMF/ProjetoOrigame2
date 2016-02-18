using UnityEngine;
using System.Collections;

public class ControladorAtaqueRacket : MonoBehaviour {

    #region Atributos e propriedades

    public GameObject player;
    public GameObject Coins;

    #endregion Atributos e propriedades

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Personagem"); //Player
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (player.GetComponent<ControladorPersonagem>().atacar && col.tag == "Mosquito")
        {
            player.GetComponent<ControladorPersonagem>().Coins += 1;

            Destroy(col.gameObject);

            ControladorSom.playSound(soundFx.AtaqueAcertou);
            
            Instantiate(Coins);
        }   
        
    }
}
