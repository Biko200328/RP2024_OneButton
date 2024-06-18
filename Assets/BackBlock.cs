using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackBlock : MonoBehaviour
{
	[SerializeField] float destroyTimer;
	float timer;

	float[] speed = { 0, 0, 0 };

	// Start is called before the first frame update
	void Start()
	{
		for(int i =0;i <3;i++)
		{
			speed[i] = Random.Range(0f, 1f);
		}
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
	}
}
