using UnityEngine;
using System;
using System.Collections;

public class atari : MonoBehaviour {
	public int flag0=0;
	public bool sa;
	public bool	wa;
	public bool	to;
	public bool	go;
	public bool	hi;
	public bool	isi;
	static public int time0 = 0;
	static public int stop0 = 0;
	private GUIStyle style;
	private GUIStyle style2;
	public GUIStyle buttonStyle;
	void Start()
	{
		style = new GUIStyle();
		style.normal.textColor = Color.red; 
		style.fontSize = 50;
		style2 = new GUIStyle();
		style2.normal.textColor = Color.blue; 
		style2.fontSize = 80;
	}
	// Use this for initialization
	void OnCollisionEnter(Collision collision){
				if (collision.gameObject.name == "sapporo_yuka") {
						Debug.Log ("sapporo111");
						flag0 = 1;
						time0 = 1;
						sa = true;
				}
				if (collision.gameObject.name == "wakkanai_yuka") {
						Debug.Log ("wakkanai111");
						flag0 = 2;
						time0 = 1;
						wa = true;
				}
				if (collision.gameObject.name == "reset_yuka") {
						flag0 = 0;
						time0 = 0;
			Debug.Log ("wahaha");
				}
				if (collision.gameObject.name == "tokachi") {
						flag0 = 3;
						time0 = 1;
						to = true;
				}
				if (collision.gameObject.name == "goryou_yuka") {
						flag0 = 4;
						time0 = 1;
						go = true;
				}
				if (collision.gameObject.name == "hidaka") {
						flag0 = 5;
						hi = true;
						time0 = 1;
				}	
				if (collision.gameObject.name == "ishikari") {
						flag0 = 6;
						time0 = 1;
						isi = true;
				}
		}
	void OnGUI () {
				if (flag0 == 0) {
						GUI.Label (new Rect (100, 100, 500, 500), "", style);	
				}
				if (flag0 == 1) {
						// ラベルを表示する
						GUI.Label (new Rect (100, 100, 500, 500), "札幌\n北海道における道庁所在地\nこの時計台は正式名称を\n「旧札幌農学校演武場」\n（きゅうさっぽろのうがっこうえんぶじょう）と称する。", style);
				}
				if (flag0 == 2) {
			GUI.Label (new Rect (100, 100, 500, 500), "日本最北端の地の碑\n稚内(わっかない)市にある宗谷(そうや)岬に建てられている石碑\n一般人が行くことのできる範囲における\n日本最北端の地である。", style);	
				}
				if (flag0 == 3) {
						GUI.Label (new Rect (100, 100, 500, 500), "十勝平野\n北海道東部の台地性の平野である\nしばしば「日本のウクライナ」と形容されるほど畑作が盛ん", style);	
				}
				if (flag0 == 4) {
			GUI.Label (new Rect (100, 100, 500, 500), "五稜郭(ごりょうかく)\n江戸時代末期に江戸幕府により\n蝦夷(えぞ)地の箱館（現在の北海道函館(はこだて)市）郊外に\n建造された星型の城郭である", style);	
				}
				if (flag0 == 5) {
						GUI.Label (new Rect (100, 100, 500, 500), "日高山脈\n北海道の中央南部にある山脈\n長さは南北およそ150 km", style);	
				}
				if (flag0 == 6) {
						GUI.Label (new Rect (100, 100, 500, 500), "石狩山地\n北海道中央部にある山地\n石狩岳 (1,967m) を最高峰とする", style);	
				}
				if (sa && wa && to && go && hi && isi) {
			time0 = 1;
			stop0 = 1;
						if (GUI.Button (new Rect (100, 800, 300, 100), "finish",buttonStyle)) {
								Application.LoadLevel ("start");
						}
			GUI.Label(new Rect(100, 460, 100, 100), "SCORE",style2);
			GUILayout.BeginArea (new Rect (0,0,200,1200));
			GUILayout.FlexibleSpace();
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			GUILayout.Label(String.Format("{0:00}",Countdown.score),style2);
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			GUILayout.FlexibleSpace();
			GUILayout.EndArea();
				}
		}
}