using UnityEngine;
using System.Collections;

public class PlayerInputController : MonoBehaviour {

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
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal1"), 0, Input.GetAxisRaw("Vertical1"));

        bool jumpInput = Input.GetButtonDown("Jump1");
        bool punchInput = Input.GetButtonDown("Punch1");

        Current = new PlayerInput()
        {
            MoveInput = moveInput,
            PunchInput = punchInput,
            JumpInput = jumpInput
        };
	}
}
