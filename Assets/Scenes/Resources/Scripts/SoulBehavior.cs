using UnityEngine;
using System.Collections;

public class SoulBehavior : MonoBehaviour {

	public float speed;
	public float scale;

	void Start () {
		speed = Random.Range (2, 5);
		gameObject.GetComponent<Rigidbody> ().velocity = transform.right * speed;
	}

	void Update () {

	}
		
	protected void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag!="Soul" && collider.gameObject.tag!="SoulAnimation")
		{
			DestroySoul ();
		}
	}

	public void DestroySoul(){
		if (Application.isPlaying) {
			DestroyObject (this.gameObject);
		} else { //precisa pros testes
			DestroyImmediate(this.gameObject);
		}
	}
}
