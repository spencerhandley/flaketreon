using UnityEngine;
using System.Collections;

public class AppendImage : MonoBehaviour {

	public string url = "https://lh6.googleusercontent.com/-uuKimh_9DGI/AAAAAAAAAAI/AAAAAAAAAAA/VV0ipCD8g5s/s128-c-k/photo.jpg";

	IEnumerator Start() {

		Texture2D tex;
		tex = new Texture2D(4, 4, TextureFormat.DXT1, false);
		WWW www = new WWW(url);
		yield return www;
		www.LoadImageIntoTexture(tex);
		GetComponent<Renderer>().material.mainTexture = tex;
	}
}
