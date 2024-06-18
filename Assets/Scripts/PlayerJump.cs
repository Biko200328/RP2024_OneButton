using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
	[SerializeField] float jumpPower = 10;

	[SerializeField] bool isDoubleJump;
	[SerializeField] bool isInfiniteJump;
	[System.NonSerialized] public bool isSecond;

	[System.NonSerialized] public bool isOnFloor;

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

		if (Input.GetKeyDown(KeyCode.Space))
		{
			//無限ジャンプ
			if (isInfiniteJump)
			{
				v.y = 0;
				v.y += jumpPower;
			}
			else
			{
				//地面についているとき
				if (isOnFloor == true)
				{
					v.y = 0;
					v.y += jumpPower;
				}
				else
				{
					//ダブルジャンプ
					if (isDoubleJump == true)
					{
						if (isSecond == false)
						{
							v.y = 0;
							v.y += jumpPower;
							isSecond = true;
						}
					}
				}
			}
		}

		rb.velocity = v;
	}
}
