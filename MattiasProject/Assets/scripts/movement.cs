using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class movement : MonoBehaviour
{

	private Rigidbody2D rbody;
	
	private bool left = true;
	private bool right;
	public float strength;


	private bucket activeBuck;

	// Use this for initialization
	void Start ()
	{
		rbody = GetComponent<Rigidbody2D>();
		activeBuck = GetComponent<bucket>();
	}


	void Update ()
	{
		InputThings();
	}

	private void InputThings()
	{
		// move left
		if (Input.GetAxisRaw("Horizontal") < 0)
		{
			transform.Translate(-strength, 0, 0);
			left = true;
			if (left && right)
			{
				right = false;
				activeBuck.activeBuck.SetActive(false);
				activeBuck.activeBuck = activeBuck.Lbuck;
				if (activeBuck.inUse)
				{
					activeBuck.activeBuck.SetActive(true);
				}
			}



		}
		// move right
		if (Input.GetAxisRaw("Horizontal") > 0)
		{
			transform.Translate(strength, 0, 0);
			right = true;
			if (left && right)
			{
				left = false;
				activeBuck.activeBuck.SetActive(false);
				activeBuck.activeBuck = activeBuck.Rbuck;
				if (activeBuck.inUse)
				{
					activeBuck.activeBuck.SetActive(true);
				}
			}

		}
	}

	
}
