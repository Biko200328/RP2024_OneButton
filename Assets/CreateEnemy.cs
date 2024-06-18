using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
	public float createTimer;
	float timer;

	float rotate = 0.5f;
	public float radius = 20.5f;

	float speed;

	float _x;
	float _z;

	public GameObject Enemy;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		timer++;

		if (timer >= createTimer)
		{
			speed = Random.Range(0.5f, 10.0f);

			rotate += speed;

			//åªç›
			_x = radius * Mathf.Sin(rotate);
			_z = radius * Mathf.Cos(rotate);

			//ê∂ê¨
			Instantiate(Enemy, new Vector3(_x, transform.position.y, _z), Quaternion.identity);

			timer = 0;
		}

	}
}
