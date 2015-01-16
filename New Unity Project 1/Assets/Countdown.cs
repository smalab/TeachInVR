using UnityEngine;
using System;

public class Countdown : MonoBehaviour
{	
	public float startTime = 180.0f; // seconds
	public float timer;
	public bool paused = true;
	private GUIStyle style;
	private void Start()
	{
		style = new GUIStyle();
		style.normal.textColor = Color.red; 
		style.fontSize = 10;
		reset();
	}
	
	private void reset()
	{
		timer = startTime;
	}
	
	private void Update()
	{
		if (paused) return;
		timer -= Time.deltaTime;
		if (timer <= 0.0f)
		{
			timer = 0.0f;
			paused = true;
			
			// 何かの処理
		}
	}
	private void OnGUI()
	{
		GUILayout.BeginVertical(GUILayout.Width(500));
		GUILayout.Box(String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(timer / 3600f), Math.Floor(timer / 60f), Math.Floor(timer % 60f), timer % 1 * 100), GUILayout.Width(500));
		GUILayout.BeginHorizontal();		
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
	}
}