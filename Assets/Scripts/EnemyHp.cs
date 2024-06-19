using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
	[SerializeField] int maxHp;
	[SerializeField] int nowHp;
	[SerializeField] int damageNum;

	[SerializeField] GameObject deadParticle;
	[SerializeField] GameObject deadParticle2;

	SceneController sceneController;

	public GameObject center;

	float timer;
	int score = 1;
	ScoreManager scoreManager;

	public GameObject parentObj;
	public EnemyGauge enemyGauge;

	GameManager gameManager;

	// Start is called before the first frame update
	void Start()
	{
		nowHp = maxHp;

		sceneController = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<SceneController>();

		center = GameObject.FindGameObjectWithTag("Center");

		transform.LookAt(center.transform);

		scoreManager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();

		gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}

	// Update is called once per frame
	void Update()
	{
		timer++;
		if(timer >= 60)
		{
			score++;
			timer = 0;
		}
	}

	public void Damage()
	{
		nowHp -= damageNum;
		if(nowHp <= 0)
		{
			scoreManager.AddScore(score);
			enemyGauge.MinusNum();
			if(enemyGauge.ReturnNum() <= -1)
			{
				Instantiate(deadParticle, transform.position, Quaternion.identity);
				gameManager.PlayBreakSE();
				Destroy(parentObj);
			}
			else
			{
				Instantiate(deadParticle2, transform.position, Quaternion.identity);
				gameManager.PlayBreakSE();
			}
		}
	}

	public void Buff()
	{
		enemyGauge.AddNum();
	}

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "GameOverLine")
		{
			sceneController.sceneChange("3_EndScene");
		}
	}
}
