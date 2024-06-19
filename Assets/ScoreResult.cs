using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreResult : MonoBehaviour
{
	Text text;
	public bool isHighScore;
	// Start is called before the first frame update
	void Start()
	{
		text = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update()
	{
		if(isHighScore)
		{
			text.text = ScoreManager.kHighScore.ToString().PadLeft(7, '0');
		}
		else
		{
			text.text = ScoreManager.kScore.ToString().PadLeft(7, '0');
		}
	}
}
