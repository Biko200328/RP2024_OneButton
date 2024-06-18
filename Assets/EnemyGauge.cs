using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGauge : MonoBehaviour
{
	[SerializeField] float maxNum = 10;
	[SerializeField] float nowNum = 0;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		var scale = transform.localScale;
		scale.y = nowNum / maxNum;
		transform.localScale = scale;
	}

	public void AddNum()
	{
		nowNum++;
		if(nowNum >= maxNum)
		{
			nowNum = maxNum;
		}
	}

	public void MinusNum()
	{
		nowNum--;
		if (nowNum <= -1)
		{
			nowNum = -1;
		}
	}

	public float ReturnNum()
	{
		return nowNum;
	}
}
