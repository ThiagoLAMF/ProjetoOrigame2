using UnityEngine;
using System.Collections;

public class ControladorCoin : MonoBehaviour {

    #region Atributos e propriedades

    GameObject player;
    int i;

    #endregion Atributos e propriedades

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Personagem"); //Player
        i = 0;
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z);
        i++;

        if(i >= 50)
        {
            Destroy(this.gameObject);
        }
    }
}
