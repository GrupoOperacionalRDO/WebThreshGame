using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpgradePanelController : MonoBehaviour {


	public Text rangeValueUpgrade;
	public Text speedValueUpgrade;
	public Text inboundValueUpgrade;
	// Update is called once per frame
	void Update(){

		Text scoretext = GameObject.Find ("Score").GetComponent<Text> ();
		float scorevalue = GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().getScore();
		scoretext.text = scorevalue.ToString() + " souls.";
		//Valores
		rangeValueUpgrade.text = GameObject.FindGameObjectWithTag ("UpdateController").GetComponent<UpgradeController> ().getValorRange().ToString();
		speedValueUpgrade.text = GameObject.FindGameObjectWithTag ("UpdateController").GetComponent<UpgradeController> ().getValorSpeed().ToString();
		inboundValueUpgrade.text = GameObject.FindGameObjectWithTag ("UpdateController").GetComponent<UpgradeController> ().getValorInbound().ToString();

	}
}
