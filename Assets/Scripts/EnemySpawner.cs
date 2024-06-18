using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	[SerializeField] GameObject enemy;
	[SerializeField] float sideLimit;
	[SerializeField] float spawnTime;
	float timer;

	[Header("“G‚Ìî•ñ")]
	public float speed;

	[Header("ˆÚ“®‚·‚é•ûŒü 0=x,1=y,2=z")]
	[Range(0, 2)]
	public int axis;

	public int destroyTime = 100;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	private void FixedUpdate()
	{
		timer++;

		if(timer >= spawnTime)
		{
			float x = Random.Range(-sideLimit, sideLimit);
			EnemyMove enemyMove = Instantiate(enemy, new Vector3(x, transform.position.y, transform.position.z), Quaternion.identity).GetComponent<EnemyMove>();
			enemyMove.speed = speed;
			enemyMove.axis = axis;
			enemyMove.destroyTime = destroyTime;
			
			timer = 0;

		}
	}
}
