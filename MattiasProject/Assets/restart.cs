using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{

	public GameObject spawner;
	public GameObject player;
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.R))
		{
			SceneManager.LoadScene("main 1");
			
		}
	}
}
