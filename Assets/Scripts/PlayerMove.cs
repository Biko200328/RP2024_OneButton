using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	[SerializeField] float moveSpeed;
	[SerializeField] float sideLimit;

	[SerializeField] bool isLongPress;

	Rigidbody rb;

	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		var v = rb.velocity;

		//長押し
		if (isLongPress == true)
		{
			//していたら止まる
			if (Input.GetKey(KeyCode.Space))
			{
				v.x = 0;
			}
			else
			{
				v.x = moveSpeed;
			}
		}
		//そもそも長押しは付けない
		else
		{
			v.x = moveSpeed;
		}


		//反転
		if (Input.GetKeyDown(KeyCode.Space))
		{
			moveSpeed = -moveSpeed;
		}

		//反対側に行ったら戻ってくる
		var pos = transform.position;
		if (transform.position.x >= sideLimit)
		{
			pos.x = -sideLimit;
		}
		else if (transform.position.x <= -sideLimit)
		{
			pos.x = sideLimit;
		}
		transform.position = pos;

		rb.velocity = v;
	}
}
