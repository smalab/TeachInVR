using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
	
	void OnControllerColliderHit(ControllerColliderHit hit ){
		var obj = hit.gameObject;	 
		Debug.Log(obj.name);      

	if (obj.name == "RefreshArea"){ 
			Debug.Log("hit");
			Application.LoadLevel("JumpMan01");
		
		}
}
}