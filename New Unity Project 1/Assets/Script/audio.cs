﻿using UnityEngine;
using System.Collections;

public class audio : MonoBehaviour {
	public AudioClip audioClip1;
	AudioSource audioSource;
	private bool iti = true;
	private bool itii = false;
	// Use this for initialization
	void Start (){
		audioSource = gameObject.GetComponent<AudioSource> ();
		if(atari.stop0 == 0){
			audioSource.clip = audioClip1;
			audioSource.Play ();
		}
	}
	
	// Update is called once per frame
	void Update () {
			if (atari.stop0 == 1) {
						if (iti = true) {
				audio.Stop();
				iti = false;
				Debug.Log ("osii");
						}
				}
}
}