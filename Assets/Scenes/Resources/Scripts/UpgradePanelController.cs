using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpgradePanelController : MonoBehaviour {

	UpgradeController upgradeController;
	public Text scoretext;
	public Text rangeValueUpgrade;
	public Text speedValueUpgrade;
	public Text inboundValueUpgrade;
	public Text penetrationValueUpgrade;
	public Text animationCancelValueUpgrade;
	public Text rangeLvlUpgrade;
	public Text speedLvlUpgrade;
	public Text inboundLvlUpgrade;

	void Start(){
		upgradeController = GameObject.FindGameObjectWithTag ("UpdateController").GetComponent<UpgradeController> ();
	}

	// Update is called once per frame
	void Update(){

		float scorevalue = GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().getScore();
		scoretext.text = "Current souls: " + scorevalue.ToString();
		//Valores
		rangeValueUpgrade.text = costValue(upgradeController.getValorRange().ToString());
		speedValueUpgrade.text = costValue(upgradeController.getValorSpeed().ToString());
		inboundValueUpgrade.text = costValue(upgradeController.getValorInbound().ToString());
		penetrationValueUpgrade.text = costValue(upgradeController.getValorPenetration().ToString());
		animationCancelValueUpgrade.text = costValue(upgradeController.getAnimationCancel().ToString());
		rangeLvlUpgrade.text = "Lv. " + upgradeController.rangeLevel;
		speedLvlUpgrade.text = "Lv. " + upgradeController.speedLevel;
		inboundLvlUpgrade.text = "Lv. " + upgradeController.inboundLevel;

	}

	string costValue(string value){
		return "Cost: " + value; 
	}
}
