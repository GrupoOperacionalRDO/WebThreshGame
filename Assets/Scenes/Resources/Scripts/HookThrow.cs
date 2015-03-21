using UnityEngine;
using System.Collections;

public class HookThrow : MonoBehaviour
{
	public GameObject prefabHook;
	public GameObject dummy;
	public int shootForceX = 0;
	public int shootForceY = 0;
	public int shootForceZ = 0;
	
	void Update ()
	{
		if (Input.GetButtonDown ("Fire1")) {
			Vector3 mousePosition = Input.mousePosition;
			mousePosition.z = 10;
			Vector3 instancePosition = Camera.main.ScreenToWorldPoint(mousePosition);
			GameObject InstanceHook = Instantiate (prefabHook, new Vector3(1f,1.5f,-6f), Quaternion.identity) as GameObject;
			GameObject InstanceGrappleDummy = Instantiate (dummy, instancePosition, Quaternion.identity) as GameObject;
			InstanceHook.GetComponent<DrawHook>().changeAngle(InstanceGrappleDummy);
		}
	}
}
