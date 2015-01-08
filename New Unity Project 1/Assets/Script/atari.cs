using UnityEngine;
using System.Collections;

public class atari : MonoBehaviour {
	public int flag0=0;
	private GUIStyle style;
	void Start()
	{
		style = new GUIStyle();
		style.normal.textColor = Color.red; 
		style.fontSize = 30;
	}
	// Use this for initialization
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.name == "sapporo_yuka"){
			Debug.Log("sapporo111");
			flag0=1;
		}
	}
	void OnGUI () {
		if (flag0 == 1){
		// ラベルを表示する
		GUI.Label(new Rect(50,50,500,500), "sapporo");
	}
}
}