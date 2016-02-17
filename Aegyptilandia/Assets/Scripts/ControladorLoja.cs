using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControladorLoja : MonoBehaviour {

	public Text teste;
	// Use this for initialization
	void Start () {
		teste.text = "OLA";
	}

	// Update is called once per frame
	void Update () {

	}

	public void compraVida (){
		//int moedas = GameObject.Find("Personagem").GetComponent<ControladorPersonagem>().Coins;
		//float vida = GameObject.Find ("Personagem").GetComponent<ControladorPersonagem> ().vida;
		//teste.text = "" + moedas + "vida:" + vida;
		//Debug.Log (moedas);
	}

	public void compraVeneno(){

	}

	public void compraAgua(){
	}
}
