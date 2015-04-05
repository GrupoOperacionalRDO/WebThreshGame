using UnityEngine;
using System.Collections;

public class UpgradeController : MonoBehaviour {

	public float speed;
	public float range;
	public int inbound;
	void Start () {
		speed = 100F;
		range = 100F;
		inbound = 1;
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
	//Increase's
	void increaseSpeed()
	{
		speed+= 5;	
	}
	void increaseRange()
	{
		range+= 5;	
	}
	void increaseInbound()
	{
		inbound++;	
	}


}
