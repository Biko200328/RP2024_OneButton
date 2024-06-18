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

	[SerializeField] bool isPlayer;
	public CircleMove cameraMove;
	BoxCollider coll;

	[SerializeField] TitleManager titleManager;

	// Use this for initialization
	void Start()
	{
		if(isPlayer == true)
		{
			coll = GetComponent<BoxCollider>();
		}

	}

	// Update is called once per frame
	void Update()
	{
		if(titleManager != null)
		{
			if(titleManager.isStart)
			{
				Move();
			}
		}
		else
		{
			Move();
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "Enemy")
		{
			direction = !direction;

			EnemyHp enemyHp = collision.gameObject.GetComponent<EnemyHp>();
			enemyHp.Damage();

			if(cameraMove != null)
			{
				cameraMove.direction = !cameraMove.direction;
			}
		}
	}

	public void Move()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			direction = !direction;
		}

		if (isPlayer)
		{
			if (Input.GetKey(KeyCode.Space))
			{
				coll.isTrigger = true;
			}
			else
			{
				if (coll.isTrigger == true)
				{
					coll.isTrigger = false;
				}
			}

		}


		if (direction)
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
}
