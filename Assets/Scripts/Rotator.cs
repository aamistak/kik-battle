using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public float SpeedPerMin;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0, 6.0f * SpeedPerMin * Time.deltaTime);
	}
}
