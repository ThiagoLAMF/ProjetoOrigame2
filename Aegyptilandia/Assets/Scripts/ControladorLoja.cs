using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControladorLoja : MonoBehaviour {


	public Text tMoeda;
	public Text tVida;
	public Text tVeneno;
	public Text tAgua;
	public Text tAviso;

	public int precoVida;
	public int precoVeneno;
	public int precoAgua;

	//Inventario:
	private int moedas = 0;
	private float vida = 0;
	private int veneno = 0;
	private int aguaSanitaria = 0;

	// Use this for initialization
	void Start () {
		//moedas = PlayerPrefs.GetInt("Coins");
		//vida = PlayerPrefs.GetFloat ("Vida");
		//veneno =  PlayerPrefs.GetInt("Veneno");
		//aguaSanitaria =  PlayerPrefs.GetInt("Agua");
		moedas = 100;
		vida = 90;
		veneno = 90;
		aguaSanitaria = 90;

		refreshTela ();
		tAviso.text = "";
	}

	// Update is called once per frame
	void Update () {

	}

	void refreshTela() //Atualiza a tela do inventário:
	{
		tMoeda.text = "Saldo:" + moedas.ToString ();
		tVida.text = "Vida:" + vida.ToString ();
		tVeneno.text = "Veneno:" + veneno.ToString ();
		tAgua.text = "A. Sanitária:" + aguaSanitaria.ToString ();
	}
	void salvaPlayer() //Salva todas as compras
	{
		/*PlayerPrefs.SetInt("Coins",moedas);
		PlayerPrefs.SetFloat("Vida",vida);
		PlayerPrefs.SetInt("Veneno",veneno);
		PlayerPrefs.SetInt("Agua",aguaSanitaria);*/
	}
	public void compraVida ()
	{
		if ((moedas - precoVida) >= 0) //Player tem moedas
		{ 
			if (vida > 99) 
			{
				tAviso.text = "Vida cheia!";
				return;
			}
			vida += 10; //Aumenta a vida em 10%
			if(vida > 100) vida = 100;
			moedas -= precoVida;

			refreshTela ();
			salvaPlayer ();
		} 
		else //player nao tem moedas
		{
			tAviso.text = "Você não tem moedas suficientes!";
		}
	}

	public void compraVeneno()
	{
		if ((moedas - precoVeneno) >= 0) //Player tem moedas
		{ 
			if (veneno > 99) 
			{
				tAviso.text = "Veneno cheio!";
				return;
			}
			veneno += 10; //Aumenta veneno
			if(veneno > 100) veneno = 100;
			moedas -= precoVeneno;

			refreshTela ();
			salvaPlayer ();
		} 
		else //player nao tem moedas
		{
			tAviso.text = "Você não tem moedas suficientes!";
		}
	}

	public void compraAgua()
	{
		if (aguaSanitaria > 99) 
		{
			tAviso.text = "Agua Sanitária cheia!";
			return;
		}
		if ((moedas - precoAgua) >= 0) //Player tem moedas
		{ 
			aguaSanitaria += 10; //Aumenta veneno
			if(aguaSanitaria > 100) aguaSanitaria = 100;
			moedas -= precoAgua;

			refreshTela ();
			salvaPlayer ();
		} 
		else //player nao tem moedas
		{
			tAviso.text = "Você não tem moedas suficientes!";
		}
	}
}
