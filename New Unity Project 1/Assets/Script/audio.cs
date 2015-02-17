using UnityEngine;
using System.Collections;

public class audio : MonoBehaviour {
	public AudioClip audioClip;
	public AudioClip audioClip1;
	AudioSource audioSource;
	private bool iti = true;
	private bool itii = false;
	// Use this for initialization
	void Start (){
		audioSource = gameObject.GetComponent<AudioSource> ();
		if (atari.stop0 == 1) {
			audioSource.clip = audioClip;
			audio.Stop();
			itii = true;
		}
		if(atari.stop0 == 0){
			audioSource.clip = audioClip1;
		}
	}
	
	// Update is called once per frame
	void Update () {
			if (iti == true) {
				audioSource.Play ();
				iti = false;
			if(itii == true){
				audioSource.Play ();
			}
}
}
}