using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
	[SerializeField] int maxHp;
	[SerializeField] int nowHp;
	[SerializeField] int damageNum;

	[SerializeField] GameObject deadParticle;

	SceneController sceneController;

	public GameObject center;

	float timer;
	int score = 1;
	ScoreManager scoreManager;

	// Start is called before the first frame update
	void Start()
	{
		nowHp = maxHp;

		sceneController = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<SceneController>();

		center = GameObject.FindGameObjectWithTag("Center");

		transform.LookAt(center.transform);

		scoreManager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
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
			Instantiate(deadParticle, transform.position, Quaternion.identity);
			scoreManager.AddScore(score);
			Destroy(this.gameObject);
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "GameOverLine")
		{
			sceneController.sceneChange("3_EndScene");
		}
	}
}
