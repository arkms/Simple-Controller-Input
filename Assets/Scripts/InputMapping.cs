using UnityEngine;
using System.Collections;

public class InputMapping : MonoBehaviour {

    public GC_Input controllerInput;

    // Use this for initialization
    void Start () {
        controllerInput = GetComponent<GC_Input>();
	}
	
	// Update is called once per frame
	public bool GoRight ()
    {
        if (controllerInput.DPad_Right || Input.GetKey(KeyCode.RightArrow))
            return true;
        else
            return false;
    }

    public float GoHorizontalAnalog()
    {
        return controllerInput.LeftDirectional_Horizontal;
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
        if (controllerInput.DPad_Up || controllerInput.LeftDirectional_asUpButton || Input.GetKey(KeyCode.UpArrow))
            return true;
        else
            return false;
    }

    public bool GoDown()
    {
        if (controllerInput.DPad_Down || controllerInput.LeftDirectional_asDownButton || Input.GetKey(KeyCode.DownArrow))
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

    public bool AttackNow()
    {
        if (controllerInput.X_button_down || Input.GetKey(KeyCode.F))
            return true;
        else
            return false;
    }

    public bool DuckNow()
    {
        return false;
    }
}
