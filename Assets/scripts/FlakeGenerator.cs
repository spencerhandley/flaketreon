using UnityEngine;
using System.Collections;

public class FlakeGenerator : MonoBehaviour {
	public GameObject flake;
	public Transform flakeSpawn;

	void Update () 
	{
		if (Input.GetButtonDown("Jump"))
		{
			Vector3 position = new Vector3(Random.Range(-4.0f, 1.0f), 7, Random.Range(-13.0f, -19.0f));
			Instantiate (flake, position, Random.rotation);
		}
	}
}
