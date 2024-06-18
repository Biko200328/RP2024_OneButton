using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	[SerializeField] float scoreNum;

	Text text;

	// Start is called before the first frame update
	void Start()
	{
		text = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update()
	{
		text.text = scoreNum.ToString().PadLeft(5, '0');
	}

	public void AddScore(int x)
	{
		scoreNum += x;
	}
}
