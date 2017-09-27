using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obSpawner : MonoBehaviour
{

	public GameObject[] obstacles;

	public GameObject leftBound;
	public GameObject rightBound;
	public GameObject paps;
	public GameObject spawner;

	private float left;
	private float right;

	private float startT;

	public float dropInterval;

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
}
