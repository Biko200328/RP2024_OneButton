using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
	public bool isStart;
	public GameObject[] Objs;

	[SerializeField] SceneController sceneController;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if(isStart == false)
		{
			if(Input.GetKeyDown(KeyCode.Space))
			{
				isStart = true;
			}
		}
		else
		{
			if (Objs[0] == null && Objs[1] == null && Objs[2] == null)
			{
				sceneController.sceneChange("2_GameScene");
			}
		}

		
	}
}
