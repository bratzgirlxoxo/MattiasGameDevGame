using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class shooter : MonoBehaviour
{

	public GameObject bullet;
	public float interval;

	public GameObject topBound;
	public GameObject bottomBound;
	public GameObject paps;
	public GameObject startP;

	private float top;
	private float bottom;

	public Vector2 direction;
	public float strength;
	
	// Use this for initialization
	void Start ()
	{
		top = topBound.transform.position.y;
		bottom = bottomBound.transform.position.y;
	}

	private float startT = 0;
	void Update ()
	{
		if (startP.activeSelf == false)
		{
			if ((Time.time) - startT >= interval)
			{
				//print("shooting");
				startT = Time.time;
				GameObject bull = Instantiate(bullet, paps.transform.position, Quaternion.identity);
				float yPos = Random.Range(bottom, top);
				Vector3 pos = bull.transform.position;
				pos.y = yPos;
				bull.transform.position = pos;
			
				bull.GetComponent<Rigidbody2D>().AddForce(direction * strength);
			}
		}

		
		
	}

}
