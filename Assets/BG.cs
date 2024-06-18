using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
	public float createTimer;
	float timer;

	float rotate = 0.5f;
	public float radius = 20.5f;

	float speed;

	float _x;
	float _z;

	public GameObject Obj;

	GameManager gameManager;

	// Start is called before the first frame update
	void Start()
	{
		gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}

	// Update is called once per frame
	void Update()
	{
		timer++;

		if(gameManager.isLongPush == true)
		{
			if (timer >= createTimer / 10)
			{
				Create();

				timer = 0;
			}
		}
		else
		{
			if (timer >= createTimer)
			{
				Create();

				timer = 0;
			}
		}
		
		
	}

	public void Create()
	{
		speed = Random.Range(0.5f, 10.0f);

		rotate += speed;

		//åªç›
		_x = radius * Mathf.Sin(rotate);
		_z = radius * Mathf.Cos(rotate);

		//ê∂ê¨
		Instantiate(Obj, new Vector3(_x, transform.position.y, _z), Quaternion.identity);
	}
}
