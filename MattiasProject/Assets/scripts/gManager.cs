using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gManager : MonoBehaviour
{

	public GameObject shooter;
	private shooter shoot;
	public float speedupT;
	private float t;
	public int points;
	public TextMesh txt;	

	
	// Use this for initialization
	void Start ()
	{
		shoot = shooter.GetComponent<shooter>();
		txt = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		t += Time.deltaTime;
		if (t - speedupT >= 0)
		{
			if (shoot.interval > 0.55f)
			{
				shoot.interval -= 0.2f;
				t = 0;
			} else if (shoot.interval < 0.45f)
			{
				shoot.interval = 0.3f;
			}
		}

		txt.text = "score [ " + points + " ]";

	}
}
