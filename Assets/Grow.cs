using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
	[SerializeField] float Speed;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		var scale = transform.localScale;
		scale.y += Speed;
		transform.localScale = scale;
	}
}
