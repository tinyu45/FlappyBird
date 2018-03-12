using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour {

	public float Speed = 0.03f;
	// Use this for initialization
	void Start () {
		
	}


	void Update()
	{
		if (transform.position.x < -4) 
		{
			Destroy (gameObject);  //销毁游戏对象
		}
	}
	
	void FixedUpdate()
	{
		//水管向左移动
		transform.position -= new Vector3 (Speed, 0, 0);
	}
}
