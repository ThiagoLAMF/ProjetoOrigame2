using UnityEngine;
using System.Collections;

public class LataLixo : MonoBehaviour {

    public GameObject lataAberta;
    public GameObject lataFechada;

    public bool aberto;

    // Use this for initialization
    void Start () {

        lataAberta.SetActive(true);
        lataFechada.SetActive(false);
        aberto = true;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void interacao()
    {
        if (aberto)
        {
            lataAberta.SetActive(false);
            lataFechada.SetActive(true);
            ControladorSom.playSound(soundFx.FecharLixo);
            aberto = false;
        }
    }
}
