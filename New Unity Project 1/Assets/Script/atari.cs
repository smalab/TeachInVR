using UnityEngine;
using System.Collections;

public class Atari : MonoBehaviour {

	// Use this for initialization
	void OnControllerColliderHit(ControllerColliderHit hit){
		var obj = hit.gameObject;	 
		Debug.Log(obj.name); 
		if (obj.name == "Cube"){ 
			Debug.Log("hit");

		}

	}
}