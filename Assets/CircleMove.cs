using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMove : MonoBehaviour
{
	public float rotate = 0.5f;
	public float radius = 20.5f;

	public float speed;

	public bool direction;

	float _x;
	float _z;

	[SerializeField] GameObject targetObj;

	public CircleMove cameraMove;

	// Use this for initialization
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			direction = !direction;
		}

		if(direction)
		{
			rotate -= speed;
		}
		else
		{
			rotate += speed;
		}

		//åªç›
		_x = radius * Mathf.Sin(rotate);
		_z = radius * Mathf.Cos(rotate);

		//ç¿ïWà⁄ìÆ
		transform.position = new Vector3(_x, transform.position.y, _z);

		if (targetObj != null)
		{
			transform.LookAt(targetObj.transform);
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "Enemy")
		{
			direction = !direction;
			if(cameraMove != null)
			{
				cameraMove.direction = !cameraMove.direction;
			}
		}
	}
}
