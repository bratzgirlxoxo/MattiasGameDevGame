using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeDamage : MonoBehaviour
{

	public GameObject self;
	private float spriteT;
	private float obsT;
	private bool doublehit;

	void Update()
	{
		flashRed();
		checkObs();
	}
	
	private void OnCollisionEnter2D(Collision2D other)
	{
		GameObject thing = other.gameObject;
		
		
		if (thing.CompareTag("bullet"))
		{
			Destroy(thing);
			spriteT = Time.time;
			self.GetComponent<manager>().health--;
			
		} else if (thing.CompareTag("obs") && !doublehit)
		{
			spriteT = Time.time;
			obsT = Time.time;
			doublehit = true;
			self.GetComponent<manager>().health--;
		}
	}

	private void flashRed()
	{	
		if (spriteT > 0 && Time.time - spriteT <= 0.1)
		{
			self.GetComponent<SpriteRenderer>().color = Color.red;
		}
		else
		{
			self.GetComponent<SpriteRenderer>().color = Color.white;
			spriteT = 0;
		}
	}

	private void checkObs()
	{
		if (Time.time - obsT > 1)
		{
			doublehit = false;
			obsT = 0;
		}
	}
}
