using UnityEngine;
using System.Collections;

public class DiscFlinger : MonoBehaviour {
	public GameObject disc;
	public float spawnTime = 3f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnBall", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


//	function RandomAround (center : Vector3, minDist : float, maxDist : float) : Vector3 {
//		var v3 = Quaternion.AngleAxis(Random.Range(0.0, 360.0), Vector3.up) * Vector3.forward;
//		v3 = v3 * Random.Range(minDist, maxDist);
//		return center + v3; 
//	}

	void SpawnBall()
	{
		var newBall = GameObject.Instantiate(disc);
	}
}
