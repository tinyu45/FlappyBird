using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour {

	public float Speed = 0.005f;

	float count=0; 


	void Start()
	{
		GeneratePipe ();
	}

	void FixedUpdate()
	{
		if (count++ == 100) 
		{
			GeneratePipe ();
			count = 0;
		}
		MeshRenderer render = GetComponent<MeshRenderer> ();
		render.material.mainTextureOffset -= new Vector2 (Speed, 0);
	}


	/***
	 * 动态生成水管
	 * **/
	void GeneratePipe()
	{
		Object obj = Resources.Load ("Pipe");              //加载到内存
		GameObject pipe = GameObject.Instantiate (obj) as GameObject;    //实例化为游戏对象
	
		//设置水管位置：
		// Min:0.95, Max:2.8
		pipe.transform.position=new Vector3(pipe.transform.position.x, Random.Range(0.95f, 2.8f), 0);

	}
}
