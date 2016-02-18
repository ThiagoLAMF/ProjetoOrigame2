using UnityEngine;
using System.Collections;

public class ControladorCamera : MonoBehaviour {

    public Transform player;
    public float x;
    public float y;

    public bool segueY;

    public float transition;
    public float ajusteY;

    public Transform LL;
    public Transform LR;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate() {
        if (segueY)
        {
            y = player.position.y + ajusteY;
        }
        else
        {
            y = this.transform.position.y;
        }

        x = player.position.x;

        if (player.position.x > LL.position.x && player.position.x < LR.position.x)
        {
            transform.position = Vector3.Lerp(this.transform.position, new Vector3(x, y, this.transform.position.z), transition);
        }
    }
}
