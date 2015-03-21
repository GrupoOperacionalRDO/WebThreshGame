using UnityEngine;
using System.Collections;

public class SoulBehavior : MonoBehaviour {

	public float speed;

	void Start () 
	{
		gameObject.GetComponent<Rigidbody> ().velocity = transform.right * speed;
	}
	

	void Update () 
	{
		// Metodo inutil. Deleta
	}
		
	protected void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag!="Soul")
		{
			DestroyObject(this.gameObject);
		}
	}
}
