using UnityEngine;
using System.Collections;

public class musicOn : MonoBehaviour {

    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;


	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            audio.PlayOneShot(SoundToPlay, Volume);
        }
    }
}
