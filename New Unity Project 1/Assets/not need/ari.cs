using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	void OnCollisionStay(Collision collision){
		if(collision.gameObject.name == "Cube1")
		{
			Destroy(collision.gameObject);
		}
	}
}