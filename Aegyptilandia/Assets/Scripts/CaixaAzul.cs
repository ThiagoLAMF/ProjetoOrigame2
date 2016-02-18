using UnityEngine;
using System.Collections;

public class CaixaAzul : MonoBehaviour {

    public GameObject caixaAberta;
    public GameObject caixaFechada;

    public GameObject Personagem;
    public GameObject Coins;
    public bool aberto;

    // Use this for initialization
    void Start () {
        caixaAberta.SetActive(true);
        caixaFechada.SetActive(false);
        aberto = true;

        Personagem = GameObject.FindGameObjectWithTag("Personagem");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void interacao()
    {
        if (aberto)
        {
            caixaAberta.SetActive(false);
            caixaFechada.SetActive(true);
            ControladorSom.playSound(soundFx.FecharLixo);
            aberto = false;
            Instantiate(Coins);
            Personagem.GetComponent<ControladorPersonagem>().Coins += 2;
        }
    }
}
