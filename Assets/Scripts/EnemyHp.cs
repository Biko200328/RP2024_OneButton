using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
	[SerializeField] int maxHp;
	[SerializeField] int nowHp;
	[SerializeField] int damageNum;

	[SerializeField] GameObject deadParticle;

	// Start is called before the first frame update
	void Start()
	{
		nowHp = maxHp;
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void Damage()
	{
		nowHp -= damageNum;
		if(nowHp <= 0)
		{
			Instantiate(deadParticle, transform.position, Quaternion.identity);
			Destroy(this.gameObject);
		}
	}
}
