using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeDamage : MonoBehaviour
{

	public GameObject self;
	private float spriteT;

	void Update()
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
	
	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag.Equals("bullet"))
		{
			spriteT = Time.time;
			self.GetComponent<manager>().health--;
			
		}
	}
}
