using UnityEngine;
using System.Collections;
using System.Reflection;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class text_atari : MonoBehaviour {
	public GameObject Text;
	private GameObject PT =  GameObject.Find("place_text");

	public void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Cube1") {
				PT.GetComponent<Text> ().text = "sapporo";
		}

			//GameObject gui = GameObject.Find("GUI Text");
			//if(gui != null) gui.guiText.text = "Hit !";

	}


	static public T FindInParents<T> (GameObject go) where T : Component
	{
		if (go == null) return null;
		object comp = go.GetComponent<T>();
		
		if (comp == null)
		{
			Transform t = go.transform.parent;
			
			while (t != null && comp == null)
			{
				comp = t.gameObject.GetComponent<T>();
				t = t.parent;
			}
		}
		return (T)comp;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}