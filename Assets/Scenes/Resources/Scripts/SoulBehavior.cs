using UnityEngine;
using System.Collections;

public class SoulBehavior : MonoBehaviour {

	public float speed;

	void Start () {
		gameObject.GetComponent<Rigidbody> ().velocity = transform.right * speed;
	}
	

	void Update () {

			
	}
		
	protected void OnTriggerEnter(Collider collider)
		{
		if (collider.gameObject.tag!="Soul")
			{
				DestroyObject(this.gameObject);
			}
	}
	}
