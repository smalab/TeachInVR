using UnityEngine;
using System.Collections;

public class audio_camera : MonoBehaviour {
	public AudioClip audioClip;
	AudioSource audioSource;
	private bool iti = true;
	// Use this for initialization
	void Start (){
		audioSource = gameObject.GetComponent<AudioSource> ();
		audioSource.clip = audioClip;
		}
	
	// Update is called once per frame
	void Update () {
		if (iti == true) {
		if (atari.stop0 == 1) {
				Debug.Log ("aaaiii");
			audioSource.Play ();
				iti = false;
				Debug.Log ("osii");
			}
		}
	}
}