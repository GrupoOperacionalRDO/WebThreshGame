using UnityEngine;
using System.Collections;

public class UpgradeController : MonoBehaviour {

	public float speed, speedLevel;
	public float range, rangeLevel;
	public int inbound, inboundLevel;
	void Start () {
		speed = 10.0F;
		range = 10.0F;
		inbound = 1;
		speedLevel = rangeLevel = inboundLevel = 1;
	}
	//Get's
	public float getSpeed()
	{
		return speed;	
	}
	public float getRange()
	{
		return range;	
	}
	public int getInbound()
	{
		return inbound;	
	}
	//Get Level's
	public float getSpeedLevel()
	{
		return speedLevel;	
	}
	public float getRangeLevel()
	{
		return rangeLevel;	
	}
	public int getInboundLevel()
	{
		return inboundLevel;	
	}
	//Increase's
	public void increaseSpeed()
	{
		float soulNeed = Mathf.Pow (speedLevel, 2); //Calculo da quantidade necessaria
		if (GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().getScore () >= soulNeed) {
			GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().removeScore(soulNeed);
			speed++;
			speedLevel++;	
		}
	}
	public void increaseRange()
	{
		float soulNeed = Mathf.Pow (rangeLevel, 2); //Calculo da quantidade necessaria
		if (GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().getScore () >= soulNeed) {
			GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().removeScore(soulNeed);
			range++;	
			rangeLevel++;		
		}
	}
	public void increaseInbound()
	{
		float soulNeed = Mathf.Pow (inboundLevel, 2); //Calculo da quantidade necessaria
		if (GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().getScore () >= soulNeed) {
			GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().removeScore(soulNeed);
			inbound++;	
			inboundLevel++;	
		}
	}


}
