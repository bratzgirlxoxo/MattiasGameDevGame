using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

	public GameObject self;
	public GameObject manager;

	public float startT;

	void Start()
	{
		startT = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - startT >= 7f)
		{
			Destroy(self);
		}
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		GameObject thing = other.gameObject;
		
		if (thing.tag.Equals("ground") || thing.tag.Equals("obs"))
		{
			Destroy(self); 
			print("ground hitter");
		} else if (thing.tag.Equals("Player"))
		{
			Destroy(self);
			print("player hit");
		} else if (thing.tag.Equals("bullet"))
		{
			Destroy(thing);
			Destroy(self);
		} 
	}
}
