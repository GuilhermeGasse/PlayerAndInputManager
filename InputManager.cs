using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//The input manager system
public class InputManager : MonoBehaviour
{   //Receive the variable input
    InputPlayerControls playercontrol;
    //The movement direction of two dimensions: front, back,left, right.
    public Vector2 MovementInput;
    public float VerticalInput;
    public float HorizontalInput;
    //Activate the inputcontrol
    private void OnEnable()
    {   //If is not activated, do active.
        if (playercontrol == null)
        {   //New instance of class
            playercontrol = new InputPlayerControls();
            //When the movement player "is maked", active the function: 
            //movement receive the i - vector2 value. 
            //"Cause" the movement direction.
            playercontrol.PlayerMovement.Movement.performed += i => MovementInput = i.ReadValue<Vector2>();
        }
        //Do active the player control
        playercontrol.Enable();
    }
    private void OnDisable()
    {
        playercontrol.Disable();
    }

    public void handleallinputs()
    {
        handlemovementinput();
        //handleactioninput
    }
    private void handlemovementinput()
    {   //Vertical input equals the movement input in the axis Y
        VerticalInput = MovementInput.y;
        //Horizontal input equals the movement input in the axis X
        HorizontalInput = MovementInput.x;
    }
}
