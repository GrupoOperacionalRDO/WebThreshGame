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
			float z = Random.Range (-4.5F, 8F);
			float x = Random.Range (-10.0F, -8.0F);
			spawnSoul(x,z);
		}
	}

	public GameObject spawnSoul(float x, float z){
		return Instantiate(soul, new Vector3(x, 1f, z), Quaternion.identity) as GameObject;
	}
}
