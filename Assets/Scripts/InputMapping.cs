using UnityEngine;
using System.Collections;

public class InputMapping : MonoBehaviour {

    private GameControllerInputs controllerInput;

    // Use this for initialization
    void Start () {
        controllerInput = GetComponent<GameControllerInputs>();
	}

    // Methods called by any object using the GameControllerInputs script to perform their movement.

    //Get Input to Go Right at a fixed speed.
    public bool GoRight ()
    {
        if (controllerInput.DPad_Right || Input.GetKey(KeyCode.RightArrow))
            return true;
        else
            return false;
    }

    //Get Input to Go Left and Right at a variable speed depending on the directional stick movement.
    public float GoHorizontalAnalog()
    {
        return controllerInput.LeftDirectional_Horizontal;
    }

    //Get Input to Go Left at a fixed speed.
    public bool GoLeft()
    {
        if (controllerInput.DPad_Left || Input.GetKey(KeyCode.LeftArrow))
            return true;
        else
            return false;
    }

    //Get Input to Go Up at a fixed speed.
    public bool GoUp()
    {
        if (controllerInput.DPad_Up || controllerInput.LeftDirectional_asUpButton || Input.GetKey(KeyCode.UpArrow))
            return true;
        else
            return false;
    }

    // Get Input to Go Down at a fixed speed.
    public bool GoDown()
    {
        if (controllerInput.DPad_Down || controllerInput.LeftDirectional_asDownButton || Input.GetKey(KeyCode.DownArrow))
            return true;
        else
            return false;
    }

    // Get Input toJump (Only used by the Alien)
    public bool JumpNow()
    {
        if (controllerInput.A_button_down || Input.GetKeyDown(KeyCode.Space))
            return true;
        else
            return false;
    }

    //Get Input to Attack (Only used by the Alien)
    public bool AttackNow()
    {
        if (controllerInput.X_button_down || Input.GetKeyDown(KeyCode.F))
            return true;
        else
            return false;
    }

    //Not used
    public bool DuckNow()
    {
        return false;
    }

    //Get input to set the Alien as the active character.
    public bool ChangeToAlien()
    {
        if (controllerInput.LB_down || Input.GetKeyDown(KeyCode.Alpha1))
            return true;
        else
            return false;

    }

    //Get input to set the Ship as the active character.
    public bool ChangeToShip()
    {
        if (controllerInput.RB_down || Input.GetKeyDown(KeyCode.Alpha2))
            return true;
        else
            return false;
    }

    //Get Input (press button down) to Shoot a coin downwards (Only used by the Ship)
    public bool ShootCoinDown()
    {
        if (controllerInput.RightDir_press_down || Input.GetKeyDown(KeyCode.Space))
            return true;
        else
            return false;
    }

    //Get Input (release button) to Shoot a coin upwards (Only used by the Ship)
    public bool ShootCoinUp()
    {
        if (controllerInput.RightDir_press_up || Input.GetKeyUp(KeyCode.Space))
            return true;
        else
            return false;
    }
}
