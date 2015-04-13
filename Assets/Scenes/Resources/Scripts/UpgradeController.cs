using UnityEngine;
using System.Collections;

public class UpgradeController : MonoBehaviour {

	public float speed, speedLevel;
	public float range, rangeLevel;
	public int inbound, inboundLevel;
	public bool penetration;
	public bool animationCancel;
	void Start () {
		penetration = false;
		animationCancel = false;
		speed = 100F;
		range = 100F;
		inbound = 1;
		speedLevel = rangeLevel = inboundLevel = 1;
	}

	//Get's
	public float getSpeed()
	{
		return speed/10;	
	}
	public float getRange()
	{
		return range/10;	
	}
	public int getInbound()
	{
		return inbound;	
	}
	public bool getPenetration()
	{
		return penetration;
	}
	public bool getAnimationCancel()
	{
		return animationCancel;
	}

	//Increase's
	void increaseSpeed()
	{
		if (GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().getScore () >= getValorSpeed ()) {
			GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().removeScore (getValorSpeed ());
			speed += 5;	
			speedLevel++;
		}
	}
	void increaseRange()
	{
		if (GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().getScore () >= getValorRange ()) {
			GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().removeScore (getValorRange ());
			range += 5;	
			rangeLevel++;
		}
	}
	void increaseInbound()
	{
		if (GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().getScore () >= getValorInbound ()) {
			GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().removeScore (getValorInbound ());
			inbound++;	
			inboundLevel++;
		}
	}

	//Set on
	void setPenetrationOn()
	{
		if (GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().getScore () >= getValorPenetration () && !penetration) {
			GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().removeScore (getValorPenetration ());
			penetration = true;
		}
	}
	void setAnimationCancelOn()
	{
		if (GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().getScore () >= getValorAnimationCancel () && !animationCancel) {
			GameObject.FindGameObjectWithTag ("HUD").GetComponent<HUDController> ().removeScore (getValorAnimationCancel ());
			animationCancel = true;
		}
	}

	//Calculo dos valores
	public float getValorSpeed()
	{
		return Mathf.Pow (speedLevel,2);
	}
	public float getValorRange()
	{
		return Mathf.Pow (rangeLevel,2);
	}
	public float getValorInbound()
	{
		return Mathf.Pow (inboundLevel,2);
	}
	public float getValorPenetration()
	{
		return 100F;
	}
	public float getValorAnimationCancel()
	{
		return 10F;
	}


}
