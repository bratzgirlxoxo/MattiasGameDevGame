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
		if (other.gameObject.tag.Equals("ground"))
		{
			Destroy(self); 
		} else if (other.gameObject.tag.Equals("Player"))
		{
			other.gameObject.GetComponent<manager>().health--;
			Destroy(self);
			print("player hit");
		}
	}
}
