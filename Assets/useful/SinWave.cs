using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinWave : MonoBehaviour
{
	float sin;
	float sinTimer;

	[Header("速さ変更 大<-速く")]
	[SerializeField] float f = 1.0f;
	[Header("反復距離 大<-小さく")]
	[SerializeField] float n = 2.0f;

	[Header("動かすかどうか")]
	[SerializeField] bool isPlay;
	[Header("縦か横か true 横 / false 縦")]
	[SerializeField] bool isDirection = false;
	[Header("動き始め反転")]
	[SerializeField] bool isOrientation = false;
	[Header("timeScaleに参照されないように")]
	[SerializeField] bool isFreedom = false;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		sinTimer += 0.02f;

		if (isPlay)
		{

			if (isFreedom)
			{
				sin = Mathf.Sin(1 * Mathf.PI * f * sinTimer);
			}
			else
			{
				sin = Mathf.Sin(1 * Mathf.PI * f * Time.time);
			}


			var pos = transform.position;

			if (isDirection)
			{
				if (isOrientation)
				{
					pos.x -= (sin / n);
				}
				else
				{
					pos.x += (sin / n);
				}
			}
			else
			{
				if (isOrientation)
				{
					pos.y -= (sin / n);
				}
				else
				{
					pos.y += (sin / n);
				}
			}

			transform.position = pos;
		}

	}
}
