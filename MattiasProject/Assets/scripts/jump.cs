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
		
		
		
		if (onGround && Input.GetKeyDown(KeyCode.W))
		{
			rbody.AddForce(Vector2.up * strength, ForceMode2D.Impulse);
		}
	}

	void OnCollisionExit2D(Collision2D col)
	{
		if (col.gameObject.tag.Equals("ground"))
		{
			onGround = false;
			print("IN AIR");
		}

	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag.Equals("ground"))
		{
			onGround = true;
			print("ON GROUND");
		}
	}
}
