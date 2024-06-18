using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
	public GameObject playerBullet;

	public float bulletSpeed;

	[Header("���˂������ 0=x,1=y,2=z")]
	[Range(0, 2)]
	public int axis;

	public int destroyTime;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			PlayerBullet pb = Instantiate(playerBullet, transform.position, Quaternion.identity).GetComponent<PlayerBullet>();
			pb.speed = bulletSpeed;
			pb.axis = axis;
			pb.destroyTime = destroyTime;
		}
		
	}
}