using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucket : MonoBehaviour
{


	public GameObject Lbuck;
	public GameObject Rbuck;
	public GameObject activeBuck;

	private float startT;
	private float endT;
	private bool canUse = true;
	public bool inUse;

	public float bucketTime;
	
	// Update is called once per frame
	void Update () {
		if (inUse == false && (Time.time - endT) >= bucketTime)
		{
			canUse = true;
		}
		
		
		if (Input.GetKeyDown(KeyCode.S) && canUse)
		{
			if (activeBuck.activeSelf)
			{
				
				inUse = false;
				endT = Time.time;
				canUse = false;

				activeBuck.SetActive(false);
				
			}
			else
			{
				startT = Time.time;
				inUse = true;
				
				activeBuck.SetActive(true);
			}
			
		}

		if (Time.time - startT >= bucketTime && inUse)
		{
			canUse = false;
			inUse = false;
			endT = Time.time;
			
			activeBuck.SetActive(false);
		}
		
	}
}
