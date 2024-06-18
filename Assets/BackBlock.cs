using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackBlock : MonoBehaviour
{
	[SerializeField] float destroyTimer;
	float timer;

	float[] speed = { 0, 0, 0 };

	public float upSpeed;
	public float upFastSpeed;

	Rigidbody rb;

	GameManager gameManager;


	// Start is called before the first frame update
	void Start()
	{
		for(int i =0;i <3;i++)
		{
			speed[i] = Random.Range(0f, 2f);
		}

		rb = GetComponent<Rigidbody>();

		gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}

	// Update is called once per frame
	void Update()
	{
		timer++;
		if(timer >= destroyTimer)
		{
			Destroy(this.gameObject);
		}

		transform.localEulerAngles += new Vector3(speed[0], speed[1], speed[2]);

		var v = rb.velocity;

		if(gameManager.isLongPush == true)
		{
			v.y = upFastSpeed;
		}
		else
		{
			v.y = upSpeed;
		}

		rb.velocity = v;
	}
}
