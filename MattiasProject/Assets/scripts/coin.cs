using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{

	public float lifetime;
	public GameObject self;
	private float birth;

	private void Start()
	{
		birth = Time.time;
	}

	// Update is called once per frame
	void Update () {
		if (Time.time - birth >= lifetime)
		{
			Destroy(self);
		}
	}

	
}
