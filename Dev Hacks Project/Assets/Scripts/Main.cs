using UnityEngine;
using System.Collections;
using SimpleJSON;

public class Main : MonoBehaviour {

	private const string URL = "http://www.webv.ro/devhacks/public/upload.php";

	private IEnumerator Start () {
		WWWForm form = new WWWForm();
		string postString = "";
		form.AddField ("post", postString);
		WWW www = new WWW (URL, form);
		yield return www;
		Debug.Log (www.text);
	}
}
