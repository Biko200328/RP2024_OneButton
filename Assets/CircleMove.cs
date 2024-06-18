using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMove : MonoBehaviour
{
	public float rotate = 0.5f;
	public float radius = 20.5f;

	public float speed;

	float _x;
	float _z;

	[SerializeField] GameObject targetObj;

	// Use this for initialization
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		rotate -= speed;

		//現在
		_x = radius * Mathf.Sin(rotate);
		_z = radius * Mathf.Cos(rotate);

		//座標移動
		transform.position = new Vector3(_x, transform.position.y, _z);

		if (targetObj != null)
		{
			transform.LookAt(targetObj.transform);
		}
	}
}
