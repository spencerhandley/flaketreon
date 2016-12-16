using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using UnityEngine.Networking;

public class PledgeManager : MonoBehaviour {

	private Pledge[] pledges;

	public Pledge getPledge() {
		return pledges [0];
	}

	public void test() {
		print ("HELLS YEAH");
	}

	void Start() {
		pledges = LoadPledges();
	}

	[System.Serializable]
	public class PledgeList {
		public Pledge[] pledges;
	}

	[System.Serializable]
	public class Pledge {
		public int amount_cents;
		public int created_at;
		public string creator_name;
		public string creator_photo;
		public string is_nsfw;
		public string location_name;
		public string patron_name;
	}
		
	private Pledge[] LoadPledges() {
		string toParse = File.ReadAllText (Application.dataPath + "/resources/pledges.json");

		PledgeList pledgeList = JsonUtility.FromJson<PledgeList>(toParse);

		Debug.Log (pledgeList.pledges.Length);

		foreach (Pledge pledge in pledgeList.pledges) {
			Debug.Log(pledge.creator_name);
		}

		return pledgeList.pledges;
	}
}


