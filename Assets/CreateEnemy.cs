using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
	public float createTime;
	float timer;

	float rotate = 0.5f;
	public float radius = 20.5f;

	float speed;

	float _x;
	float _z;

	[SerializeField] float growSpeed;
	[SerializeField] float fastGrowSpeed;

	public GameObject Enemy;

	public int level;
	public int lvUpTime;
	int lvTimer;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		timer++;
		lvTimer++;

		if (timer >= createTime)
		{
			speed = Random.Range(0.5f, 10.0f);

			rotate += speed;

			//åªç›
			_x = radius * Mathf.Sin(rotate);
			_z = radius * Mathf.Cos(rotate);

			//ê∂ê¨
			Grow grow = Instantiate(Enemy, new Vector3(_x, transform.position.y, _z), Quaternion.identity).GetComponent<Grow>();
			grow.speed = growSpeed;
			grow.fastSpeed = fastGrowSpeed;

			timer = 0;
		}

		if(lvTimer >= lvUpTime)
		{
			level++;
			growSpeed += growSpeed / 2;
			fastGrowSpeed += growSpeed / 2;
			createTime -= 10;
			lvTimer = 0;
		}

	}
}
