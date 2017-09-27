using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR.WSA;

public class manager : MonoBehaviour
{
	public GameObject self;
	public GameObject bucket;
	public GameObject leftShoot;
	public GameObject[] healthBar;
	public GameObject spawner;

	public int health;
	public int ammo;
	public float directionSwitch;

	private float startT;
	private bool leftShooter = true;
	
	// Use this for initialization
	void Start ()
	{
		ammo = 0;
		health = 10;
	}
	
	// Update is called once per frame
	void Update () {

		for (int i = 0; i < 10; i++)
		{
			if ((i + 1) <= health)
			{
				healthBar[i].SetActive(true);
			}
			else
			{
				healthBar[i].SetActive(false);
			}
		}
		
		if (health <= 0)
		{
			Destroy(self);
		}

		Vector2 pos = leftShoot.transform.position;
		Vector2 right = new Vector2(1, 0);
		Vector2 left = new Vector2(-1, 0);
		
		if (Time.time - startT >= directionSwitch)
		{
			startT = Time.time;
			leftShooter = !leftShooter;
			if (leftShooter)
			{
				pos.x = -16;
				leftShoot.GetComponent<shooter>().direction = right;
			}
			else
			{
				pos.x = 16;
				leftShoot.GetComponent<shooter>().direction = left;
			}
			leftShoot.transform.position = pos;
		}


		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
		
		spawner.SetActive(true);
		GetComponent<movement>().enabled = false;
		GetComponent<bucket>().enabled = false;
		GetComponent<jump>().enabled = false;
		
		Vector2 pos = transform.position;
		pos.y = 1.35f;
		pos.x = 0f;
		transform.position = pos;
	}
}
