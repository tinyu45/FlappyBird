using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdFly : MonoBehaviour {

	public Text scoreText;
	public Vector2 UpVelocity = new Vector2 (0, 2);

	int score;

	public static bool isOver;

	// Use this for initialization
	void Start () {
		score = 0;
		isOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isOver) 
		{   
			if (transform.position.y <= -3) 
			{
				UnityEngine.SceneManagement.SceneManager.LoadScene ("Start");
			}
			return;
		}
		if (Input.GetMouseButtonDown (0)) {
			Rigidbody2D rig = GetComponent<Rigidbody2D> ();
			rig.velocity = UpVelocity;  //给游戏物体添加速度
		}
	}


	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "Score_Collder") {
			score++;
			scoreText.text = score + "";
		} 
		else 
		{
			PlayerPrefs.SetInt ("HIGH_SCORE", score);
			isOver = true;
//			print ("GAME OVER");
		}

	}
}
