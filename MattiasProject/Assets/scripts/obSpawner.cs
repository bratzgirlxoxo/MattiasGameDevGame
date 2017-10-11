using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obSpawner : MonoBehaviour
{

	public GameObject[] obstacles;

	public GameObject coin;
	public GameObject leftBound;
	public GameObject rightBound;
	public GameObject paps;
	public GameObject spawner;

	private float left;
	private float right;
	private float startT;
	private float coinT;

	public float dropInterval;
	public int lowBoundCoinSpawn;
	public int highBoundCoinSpawn;
	
	
	// Use this for initialization
	void Start ()
	{
		left = leftBound.transform.position.x;
		right = rightBound.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		if ((Time.time - startT >= dropInterval) && (spawner.activeSelf == false))
		{
			startT = Time.time;
			dropObj();
			
		}
		
		dropCoin();
	}

	void dropObj()
	{
		int rndint = Random.Range(0, 2);
		GameObject obs = Instantiate(obstacles[rndint], paps.transform.position, Quaternion.identity);
		float xPos = Random.Range(left, right);
		Vector3 pos = obs.transform.position;
		pos.x = xPos;
		obs.transform.position = pos;
	}

	void dropCoin()
	{
		if (coinT == 0)
		{
			coinT = Random.Range(lowBoundCoinSpawn, highBoundCoinSpawn + 1) + Time.time;
		} else if (Time.time - coinT >= 0)
		{
			GameObject collectable = Instantiate(coin, paps.transform.position, Quaternion.identity);
			float xPos = Random.Range(left, right);
			Vector3 pos = collectable.transform.position;
			pos.x = xPos;
			collectable.transform.position = pos;

			coinT = 0;
		}
	}
}
