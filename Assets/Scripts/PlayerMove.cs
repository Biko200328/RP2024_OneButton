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

		//’·‰Ÿ‚µ
		if (isLongPress == true)
		{
			//‚µ‚Ä‚¢‚½‚çŽ~‚Ü‚é
			if (Input.GetKey(KeyCode.Space))
			{
				v.x = 0;
			}
			else
			{
				v.x = moveSpeed;
			}
		}
		//‚»‚à‚»‚à’·‰Ÿ‚µ‚Í•t‚¯‚È‚¢
		else
		{
			v.x = moveSpeed;
		}


		//”½“]
		if (Input.GetKeyDown(KeyCode.Space))
		{
			moveSpeed = -moveSpeed;
		}

		//”½‘Î‘¤‚És‚Á‚½‚ç–ß‚Á‚Ä‚­‚é
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
