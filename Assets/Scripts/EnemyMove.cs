using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class EnemyMove : MonoBehaviour
{
	public float speed;
	Rigidbody rb;

	[Header("ˆÚ“®‚·‚é•ûŒü 0=x,1=y,2=z")]
	[Range(0, 2)]
	public int axis;

	public int destroyTime = 100;
	int timer;

	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		var v = rb.velocity;

		if (axis == 0)
		{
			v.x = speed;
		}
		else if (axis == 1)
		{
			v.y = speed;
		}
		else if (axis == 2)
		{
			v.z = speed;
		}

		rb.velocity = v;
	}

	private void FixedUpdate()
	{
		timer++;
		if (timer >= destroyTime)
		{
			Destroy(this.gameObject);
		}
	}
}
