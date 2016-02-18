using UnityEngine;
using System.Collections;

public enum soundFx
{
    AtaqueAcertou,
    AtaqueErrou,
    Picado,
    Pulo,
    FecharLixo
}

public class ControladorSom : MonoBehaviour {

    private AudioSource audio;

    public AudioClip AtaqueAcertou;
    public AudioClip AtaqueErrou;
    public AudioClip Picado;
    public AudioClip Pulo;
    public AudioClip FecharLixo;

    public static ControladorSom instance;

    // Use this for initialization
    void Start () {

        audio = this.GetComponent<AudioSource>();

        instance = this;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void playSound(soundFx currentSound)
    {

        switch (currentSound)
        {
            case soundFx.AtaqueAcertou:
                instance.audio.PlayOneShot(instance.AtaqueAcertou);
                break;
            case soundFx.AtaqueErrou:
                instance.audio.PlayOneShot(instance.AtaqueErrou);
                break;
            case soundFx.Picado:
                instance.audio.PlayOneShot(instance.Picado);
                break;
            case soundFx.Pulo:
                instance.audio.PlayOneShot(instance.Pulo);
                break;
            case soundFx.FecharLixo:
                instance.audio.PlayOneShot(instance.FecharLixo);
                break;
        }
    }
}
