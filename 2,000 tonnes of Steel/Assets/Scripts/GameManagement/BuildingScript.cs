using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingScript : MonoBehaviour {

    public AudioClip BuildingDestroyed;

    AudioSource BuildAudio;

    void Start() {

		BuildAudio = GetComponent<AudioSource>();

    }

	void SelfDestruct () {

		BuildAudio.Play();

		GetComponent<BoxCollider>().enabled = false;

		foreach (Transform child in transform) {
			child.GetComponent<MeshRenderer>().enabled = false;
		}

		Invoke("AudioFinsihed", 3.1f);

    }

	void OnCollisionEnter(Collision other) {

        SelfDestruct();

		}

	void AudioFinished (){
	
		Destroy(gameObject);
	
	}
}

