using UnityEngine;
using System.Collections;

public class audio : MonoBehaviour {
	public AudioClip se;
	private bool iti;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (atari.stop0 == 1) {
			if(iti = true){
			audio.PlayOneShot(se);
				iti=false;
				}
	}
}
}