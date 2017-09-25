using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

	private Rigidbody2D rbody;
	
	private float maxVelocity = 3;
	private jump jumper;
	private bool left = true;
	private bool right;


	private bucket activeBuck;

	// Use this for initialization
	void Start ()
	{
		rbody = GetComponent<Rigidbody2D>();
		jumper = GetComponent<jump>();
		activeBuck = GetComponent<bucket>();
	}

	public float strength;
	void Update ()
	{
		// move left
		if (Input.GetAxis("Horizontal") < 0)
		{
			rbody.AddForce(Vector2.left * strength);
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
		if (Input.GetAxis("Horizontal") > 0)
		{
			rbody.AddForce(Vector2.right * strength);

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
