using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flake : MonoBehaviour {

	private PledgeManager.Pledge pledge;

	public void setPledge(PledgeManager.Pledge toSet) {
		pledge = toSet;
		print (pledge.creator_name);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}