using UnityEngine;
using System;
using System.Collections;
public class Countdown : MonoBehaviour
{	
	public float startTime = 10.0f; // seconds
	public float timer;
	public bool paused = true;
	public GUIStyle style1;
	private GUIStyle style;
	private void Start()
	{
		reset();
		style = new GUIStyle();
		style.normal.textColor = Color.red; 
		style.fontSize = 50;
	}
	
	private void reset()
	{
		timer = startTime;
	}
	
	private void Update()
	{
		if (atari.time0 == 0) {
						timer -= Time.deltaTime;
				}
		if (atari.time0 == 1) {
						Debug.Log ("sasuga");
						paused = true;
				} 
		}
	private void OnGUI()
	{
		if (timer <= 0.0f) {
			timer = 0.0f;
			paused = true;
			if (GUI.Button (new Rect (100, 800, 300, 100), "finish", style1)) {
				Application.LoadLevel ("start");
				// 何かの処理
			}
		}
		GUILayout.Label(String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(timer / 3600f), Math.Floor(timer / 60f), Math.Floor(timer % 60f), timer % 1 * 100),style);
		}
}