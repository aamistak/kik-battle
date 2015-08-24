using UnityEngine;
using System.Collections;

public class PlayerBounce : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		Debug.Log ("in trigger");

		if (col.gameObject.tag == "Player1")
		{
			col.gameObject.GetComponent<PlayerMachine>().bounceBack(transform.position);
		}

		if (col.gameObject.tag == "Player2")
		{
			col.gameObject.GetComponent<Player2Machine>().bounceBack(transform.position);
		}
	}
}
