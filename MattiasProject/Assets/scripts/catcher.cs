using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR.WSA;

public class catcher : MonoBehaviour
{

	public GameObject[] bullets;
	public GameObject manager;
	public GameObject wall;
	private manager man;
	public float distance;
	public GameObject buck;
	private bucket buckt;


	void Start()
	{
		man = manager.GetComponent<manager>();
		buckt = buck.GetComponent<bucket>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (man.ammo == 3 && Input.GetKeyDown(KeyCode.Space))
		{
			GameObject newWall = Instantiate(wall, new Vector3(transform.position.x - distance, transform.position.y, transform.position.z), Quaternion.identity);
			Vector2 pos = newWall.transform.position;
			
			if (buckt.activeBuck.Equals(buckt.Lbuck))
			{
				pos.x -= distance;
			}
			else
			{
				pos.x += distance * 3;
			}
			
			newWall.transform.position = pos;
			man.ammo = 0;
			print("zero ammo!");
		}

		for (int i = 0; i < bullets.Length; ++i)
		{
			if (man.ammo > i)
			{
				bullets[i].SetActive(true);
			}
			else
			{
				bullets[i].SetActive(false);
			}
		}
		
		
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag.Equals("bullet"))
		{
			if (man.ammo < 3)
			{
				man.ammo++;
				
			}
			Destroy(other.gameObject);
		}
	}
}
