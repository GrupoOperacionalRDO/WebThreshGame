using UnityEngine;
using System.Collections;

public class HookThrow : MonoBehaviour
{
	public GameObject prefabHook;
	public float angleo;
	
	void Update ()
	{
		if (Input.GetButtonDown ("Fire1")) {	//Se o botao do mouse foi apertado
			if(GameObject.FindGameObjectsWithTag("Hook").Length == 0){ //Se nao existe outro hook
				Vector3 threshPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
				Vector3 threshScreenPosition = Camera.main.WorldToScreenPoint(threshPosition);
				Vector3 mousePosition = Input.mousePosition; //Pega a posicao do mouse
				angleo = Mathf.Atan((mousePosition.x - threshScreenPosition.x)/Mathf.Abs(mousePosition.y - threshScreenPosition.y)) * Mathf.Rad2Deg; // Pega o angulo entre a posicao do thresh e onde foi clicado
				Quaternion angle = Quaternion.AngleAxis(angleo, Vector3.up);	//Transforma o angulo em quaternion
				Instantiate (prefabHook, threshPosition, angle); //Instancia o hook com esse angulo
			}
		}
	}

}
