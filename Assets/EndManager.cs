using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndManager : MonoBehaviour
{
	public SceneController sceneController;

	// Start is called before the first frame update
	void Start()
	{
		Screen.SetResolution(1280, 720, false);
		Application.targetFrameRate = 60;
	}

	// Update is called once per frame
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			sceneController.sceneChange("2_GameScene");
		}

		if (Input.GetKeyDown(KeyCode.T))
		{
			sceneController.sceneChange("1_TitleScene");
		}
	}
}
