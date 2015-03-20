using UnityEngine;
using System.Collections;

public class SoulSpawnController : MonoBehaviour {

	public GameObject soul;
	private int count;
	public float respawntime;
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
	if (++count >= respawntime * 60) {
			count=0;
			float z = Random.Range (-5.0F, 4.5F);
			float x = Random.Range (-4.0F, 1.0F);
			Instantiate(soul, new Vector3(x, 1, z), Quaternion.identity);
			
		}
	}
}
