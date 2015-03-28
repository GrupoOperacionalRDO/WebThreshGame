using UnityEngine;
using System.Collections;

public class GetPointAnimationBehavior : MonoBehaviour {

	void Start () {
		this.rigidbody.velocity = this.transform.forward * -7;
	}

	void OnCollisionEnter (Collision coll)
	{
		DestroyObject (this.gameObject);
	}
}
