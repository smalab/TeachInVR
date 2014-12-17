using UnityEngine;
using System.Collections;

public class atari : MonoBehaviour {

	// Use this for initialization
	void OnControllerColliderHit(ControllerColliderHit hit){
		var obj = hit.gameObject;	 
		Debug.Log(obj.name); 
		if (obj.name == "Cube1"){ 
			Debug.Log("hit");

		}

	}
}