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

	// Start is called before the first frame update
	void Start()
	{
		nowHp = maxHp;

		sceneController = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<SceneController>();
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

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "GameOverLine")
		{
			sceneController.sceneChange("3_EndScene");
		}
	}
}
