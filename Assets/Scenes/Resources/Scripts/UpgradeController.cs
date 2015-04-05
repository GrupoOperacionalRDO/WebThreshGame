using UnityEngine;
using System.Collections;

public class UpgradeController : MonoBehaviour {

	public float speed;
	public float range;
	public int inbound;
	void Start () {
		speed = 10.0F;
		range = 10.0F;
		inbound = 1;
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
	//Increase's
	void increaseSpeed()
	{
		speed++;	
	}
	void increaseRange()
	{
		range++;	
	}
	void increaseInbound()
	{
		inbound++;	
	}


}
