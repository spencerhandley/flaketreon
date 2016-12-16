using UnityEngine;
using System.Collections;

public class FlakeGenerator : MonoBehaviour {
	public Flake flake;
	public Transform flakeSpawn;

	public PledgeManager pledgeManager;

	void Update () 
	{
		if (Input.GetButtonDown("Jump"))
		{
			Vector3 position = new Vector3(Random.Range(-4.0f, 1.0f), 7, Random.Range(-13.0f, -19.0f));
			Flake newFlake = (Flake) Instantiate (flake, position, Random.rotation);

			PledgeManager.Pledge pledge = pledgeManager.getPledge ();
			newFlake.setPledge (pledge);

		}
	}
}
