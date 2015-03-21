using UnityEngine;
using System.Collections;

public class DrawHook : MonoBehaviour
{
	public float speed;
	
	void Start ()
	{	
		this.rigidbody.velocity = this.transform.forward * speed;
	}

	void Update (){
		if (this.transform.position.z > 4) {  //se ultrapassar o limite da tela, destroi o hook
			DestroyObject(this.gameObject);
		}
	}
	
	void OnTriggerEnter(Collider collider){
		if (collider.tag == "Soul") {	//adiciona um ponto se colidir com uma soul
			GameObject.FindGameObjectWithTag("HUD").GetComponent<HUDController>().addScore(1);
		}
		DestroyObject (this.gameObject);
	}
}
