using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public bool isLongPush;
	[SerializeField] float LPtime;
	float timer;

	public AudioSource breakSE;

	// Start is called before the first frame update
	void Start()
	{
		Screen.SetResolution(1280, 720, false);
		Application.targetFrameRate = 60;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.Space))
		{
			timer++;
			if(timer >= LPtime)
			{
				isLongPush = true;
			}
		}
		
		if(Input.GetKeyUp(KeyCode.Space))
		{
			timer = 0;
			isLongPush = false;
		}
	}

	public void PlayBreakSE()
	{
		breakSE.Play();
	}
}
