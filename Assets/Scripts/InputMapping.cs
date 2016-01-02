using UnityEngine;
using System.Collections;

public class InputMapping : MonoBehaviour {

    public GC_Input controllerInput;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	public bool GoRight ()
    {
        if (controllerInput.DPad_Right || Input.GetKey(KeyCode.RightArrow))
            return true;
        else
            return false;
    }

    public bool GoLeft()
    {
        if (controllerInput.DPad_Left || Input.GetKey(KeyCode.LeftArrow))
            return true;
        else
            return false;
    }

    public bool GoUp()
    {
        return false;
    }

    public bool GoDown()
    {
        if (controllerInput.DPad_Down || Input.GetKey(KeyCode.DownArrow))
            return true;
        else
            return false;
    }

    public bool JumpNow()
    {
        if (controllerInput.A_button_down || Input.GetKey(KeyCode.Space))
            return true;
        else
            return false;
    }

    public bool ShootNow()
    {
        return false;
    }

    public bool DuckNow()
    {
        return false;
    }
}
