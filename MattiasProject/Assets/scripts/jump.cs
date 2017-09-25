using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
	public bool onGround;

	private Rigidbody2D rbody;
	private BoxCollider2D coll;

	public float strength;
	// Use this for initialization
	void Start ()
	{
		rbody = GetComponent<Rigidbody2D>();
		coll = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (onGround && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)))
		{
			rbody.AddForce(Vector2.up * strength, ForceMode2D.Impulse);
		}

		if (rbody.velocity.y > 0.000001f)
		{
			onGround = false;
		}
		else
		{
			onGround = true;
		}
	}

	
}
