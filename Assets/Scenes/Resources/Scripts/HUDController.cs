/**	HUDController.cs
 *  @author: João Teló
 *   
 *	Utilizar esse componente para exibir a quantidade de pontos,
 *	colocando ele em um Canvas, que tenha como filho um Text.
 *	O acesso a variável score não é permitido diretamente, controle
 *  ela por setScore, getScore, addScore e removeScore.
 */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUDController : MonoBehaviour {

	float score = 0;

	/** Start e Update são utilizados para sincronizar o valor da variável score
	 *  com o componente Texto da HUD.
	 */

	void Start () {
		gameObject.GetComponentInChildren<Text> ().text = "Score: " + score.ToString ();
	}

	void Update () {
		gameObject.GetComponentInChildren<Text> ().text = "Score: " + score.ToString ();
	}

	public void setScore(float score){
		this.score = score;
		this.Update ();
	}

	public float getScore(){
		return this.score;
	}

	public void addScore(float points){
		this.score += points;
		this.Update();
	}

	public void removeScore(float points){
		this.addScore(-points);
	}

}
