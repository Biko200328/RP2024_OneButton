using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMove : MonoBehaviour
{
	public float rotate = 0.5f;
	public float radius = 20.5f;

	public float nowSpeed;
	public float speed;
	public float fastSpeed;

	public bool direction;

	float _x;
	float _z;

	[SerializeField] GameObject targetObj;

	[SerializeField] bool isPlayer;
	public CircleMove cameraMove;
	BoxCollider coll;

	[SerializeField] TitleManager titleManager;

	GameManager gameManager;

	// Use this for initialization
	void Start()
	{
		if(isPlayer == true)
		{
			coll = GetComponent<BoxCollider>();
		}

		gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

		nowSpeed = speed;
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
			if (gameManager.isLongPush)
			{
				nowSpeed += 0.001f;
				if(nowSpeed >= fastSpeed)
				{
					nowSpeed = fastSpeed;
				}
			}
			else
			{
				nowSpeed -= 0.002f;
				if (nowSpeed <= speed)
				{
					nowSpeed = speed;
				}
			}
			rotate -= nowSpeed;
		}
		else
		{
			if (gameManager.isLongPush)
			{
				nowSpeed += 0.001f;
				if (nowSpeed >= fastSpeed)
				{
					nowSpeed = fastSpeed;
				}
			}
			else
			{
				nowSpeed -= 0.002f;
				if (nowSpeed <= speed)
				{
					nowSpeed = speed;
				}
			}
			rotate += nowSpeed;
		}

		//Œ»Ý
		_x = radius * Mathf.Sin(rotate);
		_z = radius * Mathf.Cos(rotate);

		//À•WˆÚ“®
		transform.position = new Vector3(_x, transform.position.y, _z);

		if (targetObj != null)
		{
			transform.LookAt(targetObj.transform);
		}
	}
}
