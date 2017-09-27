using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

	public GameObject platform;
	
	
	
	// Update is called once per frame
	void Update () {
		if (platform.activeSelf && Input.GetKeyDown(KeyCode.Return))
		{
			platform.SetActive(false);
			GetComponent<movement>().enabled = true;
			GetComponent<jump>().enabled = true;
			GetComponent<bucket>().enabled = true;
		}
	}
}
