using UnityEngine;
using System.Collections;

public class atari : MonoBehaviour {
	public int flag0=0;
	private GUIStyle style;
	void Start()
	{
		style = new GUIStyle();
		style.normal.textColor = Color.red; 
		style.fontSize = 80;
	}
	// Use this for initialization
	void OnCollisionEnter(Collision collision){
				if (collision.gameObject.name == "sapporo_yuka") {
						Debug.Log ("sapporo111");
						flag0 = 1;
				}
				if (collision.gameObject.name == "wakkanai_yuka") {
						Debug.Log ("wakkanai111");
						flag0 = 2;
				}
				if (collision.gameObject.name == "reset_yuka") {
						flag0 = 0;
				}
				if (collision.gameObject.name == "tokachi") {
						flag0 = 3;
				}
		}
	void OnGUI () {
		if (flag0 == 0) {
			GUI.Label(new Rect(100,100,500,500), "",style);	
		}
		if (flag0 == 1){
		// ラベルを表示する
			GUI.Label(new Rect(100,100,500,500), "札幌",style);
	}
		if (flag0 == 2) {
			GUI.Label(new Rect(100,100,500,500), "稚内",style);	
		}
		if (flag0 == 3) {
			GUI.Label(new Rect(100,100,500,500), "十勝平野\nしてみた",style);	
	}
	}
}