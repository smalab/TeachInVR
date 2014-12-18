using UnityEngine;
using System.Collections;
using System.Reflection;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class text_atari : MonoBehaviour {
	public GameObject Text;
	private GameObject place_text;
		place_text = GameObject.Find("Text");
	public void OnCollisionStay(Collision collision){
		if(hit.Gameobject=="Cube1"){
		place_text.GetComponent<Text>().Text="sapporo"
	}

	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
