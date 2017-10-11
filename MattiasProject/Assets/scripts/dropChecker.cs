using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropChecker : MonoBehaviour
{

	private Collider2D platform;
	private float dropT;
	private bool canDrop;
	
	
	// Update is called once per frame
	void Update () {
		checkTime();
		InputThings();
	}

	private void OnCollisionStay2D(Collision2D other)
	{
		GameObject thing = other.gameObject;

		if (thing.CompareTag("ground2"))
		{
			platform = thing.GetComponent<Collider2D>();
			canDrop = true;
		}
	}

	private void OnCollisionExit2D(Collision2D other)
	{
		canDrop = false;
	}

	private void checkTime()
	{
		if (Time.time - dropT > 0.2f)
		{
			platform.enabled = true;
			dropT = 0;
		}
	}

	private void InputThings()
	{
		if (canDrop && Input.GetAxisRaw("Vertical") < 0)
		{
			dropT = Time.time;
			platform.enabled = false;
		}
	}
}
