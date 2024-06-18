using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumTest : MonoBehaviour
{
	[SerializeField]GameObject textPos;
	GameObject targetCam;

	// Start is called before the first frame update
	void Start()
	{
		targetCam = GameObject.FindGameObjectWithTag("MainCamera");
	}

	// Update is called once per frame
	void Update()
	{
		textPos.transform.position = WorldPointToScreenPoint(transform.position, targetCam.GetComponent<Camera>());
	}

	public static Vector3 WorldPointToScreenPoint(Vector3 targetPos, Camera targetCamera)
	{
		return targetCamera.WorldToScreenPoint(targetPos);
	}

}
