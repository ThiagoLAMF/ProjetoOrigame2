using UnityEngine;
using System.Collections;

public class ControladorMosquito : MonoBehaviour {

	private Transform player; //Pega posição do player
	private Transform Mosquito;

	public float Speed;

	private float startTime;
	private float journeyLength;

	public float MaxSpawnDistance;

	private bool facingRight = true;
	// Use this for initialization
	void Start () {

		Mosquito = transform; //Mosquito
		player = GameObject.FindGameObjectWithTag("Personagem").transform; //Player

		facingRight = true;// Mosquito começa olhando para a direita

		//Pega coordenada do player
		float x = player.position.x;
		float y = player.position.y;

		//Gera uma posição aleatoria no raio do player levando em conta MaxSpawnDistance
		float randx = Random.Range((x-2) - MaxSpawnDistance,(x+2) + MaxSpawnDistance);
		float randy = Random.Range((y-2) - MaxSpawnDistance,(y+2) + MaxSpawnDistance);
		Mosquito.position = new Vector3(randx,randy,0);

		startTime = Time.time;
		journeyLength = Vector3.Distance (Mosquito.position, player.position); //Distancia do mosquito até o player
		//Debug.Log("Spawn");


	}


	void FixedUpdate () {

		//----------------------Calcula a Rota do mosquito-----------------------------------//
		float dist = (Time.time - startTime) * Speed;
		float journey = dist / journeyLength;

		Mosquito.position = Vector3.Lerp (Mosquito.position, player.position, journey);

		startTime = Time.time;
		journeyLength = Vector3.Distance (Mosquito.position, player.position);
		//------------------------------------------------------------------------------------//
		//Verifica se o mosquito está na direção correta:
		if (Mosquito.position.x > player.position.x && !facingRight) { //Mosquito está a direita do player
			Flip();
		}
		if (Mosquito.position.x < player.position.x && facingRight) { //Mosquito está a esquerda do player
			Flip();
		}

	}



	void Flip()
	{

		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.tag == "Personagem") { //Destroy o Objeto quando em contato com o Player
			Destroy (gameObject);

		}

	}
	void OnParticleCollision(GameObject other) {
		Destroy (gameObject);
	}
}
