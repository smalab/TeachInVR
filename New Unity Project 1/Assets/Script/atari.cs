using UnityEngine;
using System.Collections;

public class atari : MonoBehaviour {
	public int flag0=0;
	private GUIStyle style;
	void Start()
	{
		style = new GUIStyle();
		style.normal.textColor = Color.red; 
		style.fontSize = 50;
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
				if (collision.gameObject.name == "goryou_yuka") {
						flag0 = 4;
				}
				if (collision.gameObject.name == "hidaka") {
						flag0 = 5;
				}	
				if (collision.gameObject.name == "ishikari") {
						flag0 = 6;
				}
		}
	void OnGUI () {
		if (flag0 == 0) {
			GUI.Label(new Rect(100,100,500,500), "",style);	
		}
		if (flag0 == 1){
		// ラベルを表示する
			GUI.Label(new Rect(100,100,500,500), "札幌\n北海道における道庁所在地\nこの時計台は正式名称を\n「旧札幌農学校演武場」\n（きゅうさっぽろのうがっこうえんぶじょう）と称する。",style);
	}
		if (flag0 == 2) {
			GUI.Label(new Rect(100,100,500,500), "日本最北端の地の碑\n稚内市にある宗谷岬に建てられている石碑\n一般人が行くことのできる範囲における\n日本最北端の地である。",style);	
		}
		if (flag0 == 3) {
			GUI.Label(new Rect(100,100,500,500), "十勝平野\n北海道東部の台地性の平野である\nしばしば「日本のウクライナ」と形容されるほど畑作が盛ん",style);	
	}
		if (flag0 == 4) {
			GUI.Label(new Rect(100,100,500,500), "五稜郭\n江戸時代末期に江戸幕府により\n蝦夷地の箱館（現在の北海道函館市）郊外に\n建造された星型の城郭である",style);	
		}
		if (flag0 == 5) {
			GUI.Label(new Rect(100,100,500,500), "日高山脈\n北海道の中央南部にある山脈\n長さは南北およそ150 km",style);	
		}
		if (flag0 == 6) {
			GUI.Label(new Rect(100,100,500,500), "ishikari",style);	
		}
	}
}