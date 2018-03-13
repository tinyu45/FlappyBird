using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICotroller : MonoBehaviour {

	public UnityEngine.UI.Text High_Score;

	// Use this for initialization
	void Start () {
		High_Score.text=PlayerPrefs.GetInt ("HIGH_SCORE", 0)+"";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnStartButtonClcik()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Main");
	}
}
