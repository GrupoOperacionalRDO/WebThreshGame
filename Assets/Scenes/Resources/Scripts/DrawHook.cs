using UnityEngine;
using System.Collections;

public class DrawHook : MonoBehaviour
{
	// Line start width
	public float startWidth = 0.05f;
	// Line end width
	public float endWidth = 0.05f;
	private LineRenderer line;
	public float speed;
	
	void Start ()
	{		
	}
	
	public void changeAngle(GameObject dummy){
		Vector3 lookPosition = dummy.transform.position-this.transform.position;
		lookPosition.y = 0;
		Quaternion rotation = Quaternion.LookRotation (lookPosition);
		this.transform.rotation = Quaternion.Slerp (this.transform.rotation, rotation, Time.deltaTime * 2);
		this.rigidbody.velocity = this.transform.forward * speed;
	}

	// Update is called once per frame
	void Update ()
	{
		/*
		var thresh = GameObject.Find ("Player");
		line.SetPosition (0, thresh.transform.position);
		line.SetPosition (1, this.gameObject.transform.position);
		*/
	}
}
