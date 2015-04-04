using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpgradePanelController : MonoBehaviour {

	// Update is called once per frame
	void Update(){

		Text scoretext = GameObject.Find ("Score").GetComponent<Text> ();
		float scorevalue = GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().getScore();
		scoretext.text = scorevalue.ToString() + " souls.";

	}
}
