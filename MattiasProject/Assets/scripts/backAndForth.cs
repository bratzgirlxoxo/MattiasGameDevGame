using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backAndForth : MonoBehaviour {

    public float delta;
    public float speed;
    private Vector2 startPos;

	// Use this for initialization
	void Start () {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
	}

	private void OnCollisionStay2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("bullet") == false)
		{
			other.transform.parent = transform;
		}
	}

	private void OnCollisionExit2D(Collision2D other)
	{
		other.transform.parent = null;
	}
}
