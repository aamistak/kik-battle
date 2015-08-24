using UnityEngine;
using System.Collections;

public class Player2InputController : MonoBehaviour {
	
	public PlayerInput Current;
	
	// Use this for initialization
	void Start () {
		Current = new PlayerInput();
	}
	
	// Update is called once per frame
	void Update () {
		
		// Retrieve our current WASD or Arrow Key input
		// Using GetAxisRaw removes any kind of gravity or filtering being applied to the input
		// Ensuring that we are getting either -1, 0 or 1
		Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal2"), 0, Input.GetAxisRaw("Vertical2"));
		
		bool jumpInput = Input.GetButtonDown("Jump2");
		bool punchInput = Input.GetButtonDown("Punch2");
		
		Current = new PlayerInput()
		{
			MoveInput = moveInput,
			PunchInput = punchInput,
			JumpInput = jumpInput
		};
	}
}


public struct PlayerInput
{
	public Vector3 MoveInput;
	public bool PunchInput;
	public bool JumpInput;
}
