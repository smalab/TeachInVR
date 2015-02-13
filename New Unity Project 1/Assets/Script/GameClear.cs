using UnityEngine;
using System.Collections;

public class GameClear : MonoBehaviour {

	public void Click(){
		atari.stop0 = 0;
		atari.time0 = 0;
		Application.LoadLevel("start");
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
