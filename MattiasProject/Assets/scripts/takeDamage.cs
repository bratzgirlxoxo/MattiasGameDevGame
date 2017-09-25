using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeDamage : MonoBehaviour
{

	public GameObject self;

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag.Equals("bullet"))
		{
			self.GetComponent<manager>().health--;
		}
	}
}
