using UnityEngine;
using System.Collections;
using System.Reflection;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class text_atari : MonoBehaviour {
	public GameObject Text;
	private GameObject place_text =  GameObject.Find("Text");

	public void OnCollisionStay(Collision collision){
		//if (collision.gameObject == "Cube1") {
				//place_text.GetComponent<Text> ().text = "sapporo";
		//}

			GameObject gui = GameObject.Find("GUI Text");
			if(gui != null) gui.guiText.text = "Hit !";

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}