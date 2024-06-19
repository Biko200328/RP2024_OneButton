using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
	public float speed;
	public float fastSpeed;

	[SerializeField] GameObject Red;


	float timer;
	bool isRed;
	[SerializeField] float y;
	[SerializeField] float blinkTime;

	// Start is called before the first frame update
	void Start()
	{
		Red.SetActive(false);
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

		if(scale.y >= y)
		{
			timer++;
			if(timer >= blinkTime)
			{
				isRed = !isRed;
				timer = 0;
			}

			if(isRed)
			{
				Red.SetActive(true);
			}
			else
			{
				Red.SetActive(false);
			}
		}
		else
		{
			Red.SetActive(false);
		}
	}
}
