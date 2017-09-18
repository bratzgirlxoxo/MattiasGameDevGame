using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{


	public int health;
	
	// Update is called once per frame
	void Update () {
		if (health <= 0)
		{
			Destroy(this.gameObject);
		}
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag.Equals("bullet"))
		{
			health--;
		}
	}
}
