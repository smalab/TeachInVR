using UnityEngine;
using System;
using System.Collections;

public class score : MonoBehaviour {
	private GUIStyle style;
	public GUIStyle buttonStyle;
	// Use this for initialization
	void Start () {
		style = new GUIStyle();
		style.normal.textColor = Color.red; 
		style.fontSize = 80;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		GUI.Label(new Rect(800, 460, 100, 100), "SCORE",style);
		GUILayout.BeginArea (new Rect (500,0,1000,1200));
		GUILayout.FlexibleSpace();
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.Label(String.Format("{0:00}",Countdown.score),style);
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.EndArea();
	}
}