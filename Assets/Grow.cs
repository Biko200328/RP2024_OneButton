using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
	public float speed;
	public float fastSpeed;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		var scale = transform.localScale;
		if(Input.GetKey(KeyCode.Space))
		{
			scale.y += fastSpeed;
		}
		else
		{
			scale.y += speed;
		}
		
		transform.localScale = scale;
	}
}
