using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{

	public GameObject self;
	public float lifeSpan;
	
	private float startT;
	private bool halt;
	private float hitT;

	private Rigidbody2D rbody;

	void Start()
	{
		rbody = GetComponent<Rigidbody2D>();
		startT = Time.time;
	}
	
	
	// Update is called once per frame
	void Update () {
		
		if (Time.time - startT >= lifeSpan)
		{
			Destroy(self);
		}
		
	}

	private bool land;

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (!land && other.gameObject.CompareTag("ground"))
		{
			print("LANDED");
			startT = Time.time;
			land = true;
		} 
	}
}
