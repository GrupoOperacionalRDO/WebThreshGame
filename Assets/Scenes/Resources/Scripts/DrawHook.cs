using UnityEngine;
using System.Collections;

public class DrawHook : MonoBehaviour
{
	public float speed;
	public float range; 
	public int inbound;
	public GameObject GetPointAnimation;
	private float spawnX;
	private float spawnZ;
	private GameObject hookmodel;

	void Start ()
	{	
		speed = GameObject.FindGameObjectWithTag ("UpdateController").GetComponent<UpgradeController> ().getSpeed();
		range = GameObject.FindGameObjectWithTag ("UpdateController").GetComponent<UpgradeController> ().getRange();
		inbound = GameObject.FindGameObjectWithTag ("UpdateController").GetComponent<UpgradeController> ().getInbound();
		hookmodel = GameObject.FindGameObjectWithTag ("Hookmodel");
		hookmodel.SetActive (false);
		spawnX = this.transform.position.x;
		spawnZ = this.transform.position.z;
		this.rigidbody.velocity = this.transform.forward * speed;
	}

	void Update (){
		//Calculo do Range atual
		float currentRange = Mathf.Sqrt (Mathf.Pow (Mathf.Abs (this.transform.position.x - spawnX), 2) + Mathf.Pow (Mathf.Abs (this.transform.position.z - spawnZ), 2));
		if (currentRange > range) {  //se ultrapassar o limite da tela, destroi o hook
			DestroyHook ();
		}
		if (Time.timeScale == 0) //se o jogo estiver pausado, destroi
			DestroyHook ();
	}
	
	void OnTriggerEnter(Collider collider){
		if (collider.tag == "Soul") {	//adiciona pontos de acordo com o Inbound se colidir com uma soul
			GameObject.FindGameObjectWithTag("HUD").GetComponent<HUDController>().addScore(inbound);
			Instantiate (GetPointAnimation, transform.position, transform.rotation); //Instancia o hook com esse angulo
		}
		if (collider.tag != "SoulAnimation")
			DestroyHook ();

	}

	void DestroyHook(){
		hookmodel.SetActive (true);
		if (Application.isPlaying) {
			DestroyObject (this.gameObject);
		} else { //precisa pros testes
			DestroyImmediate(this.gameObject);
		}
	}

	public void testDestroyHook(){
		Start ();
		DestroyHook ();
	}

}
