using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFloor : MonoBehaviour
{
	public PlayerMove playerMove;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Floor")
		{
			playerMove.isOnFloor = true;
			playerMove.isSecond = false;
		}
	}

	private void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Floor")
		{
			playerMove.isOnFloor = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Floor")
		{
			playerMove.isOnFloor = false;
		}
	}
}
