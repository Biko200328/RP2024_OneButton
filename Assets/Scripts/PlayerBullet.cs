using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
	public float speed;

	[Header("”­ŽË‚·‚é•ûŒü 0=x,1=y,2=z")]
	[Range(0, 2)]
	public int axis;

	public int destroyTime = 100;
	int timer;

	Rigidbody rb;

	public bool isCircle;
	public GameObject target;
	Vector3 dec;

	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody>();

		rb.useGravity = false;

		if(isCircle == true)
		{
			dec = target.transform.position - transform.position;
			dec = dec.normalized;
		}
	}

	// Update is called once per frame
	void Update()
	{
		var v = rb.velocity;

		if(isCircle == true)
		{
			v = dec * speed;
		}
		else
		{
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
		}

		rb.velocity = v;
	}

	private void FixedUpdate()
	{
		timer++;
		if(timer >= destroyTime)
		{
			Destroy(this.gameObject);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Enemy")
		{
			EnemyHp enemyHp = other.GetComponent<EnemyHp>();
			enemyHp.Buff();
			Destroy(this.gameObject);
		}
	}
}
