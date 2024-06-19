using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	[SerializeField] float scoreNum;

	Text text;

	public static float kScore;
	public static float kHighScore;

	// Start is called before the first frame update
	void Start()
	{
		text = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update()
	{
		text.text = scoreNum.ToString().PadLeft(7, '0');
	}

	public void AddScore(int x)
	{
		scoreNum += x;
	}

	public void KeepScore()
	{
		kScore = scoreNum;
		if(kScore >= kHighScore)
		{
			kHighScore = kScore;
		}
	}
}
