using UnityEngine;
using System.Collections;

public class GC_Input : MonoBehaviour {

    //Variables
    //[SerializeField]
    private float inputZeroThreshold = 0.05f;
    private float inputDigitalThreshold = 0.5f;
    public bool IsInputActive { get; private set; }

    // Directionals
    private float leftDirectional_Horizontal;
    public float LeftDirectional_Horizontal
    {
        get
        {
            if (Mathf.Abs(leftDirectional_Horizontal) >= inputZeroThreshold)
                return leftDirectional_Horizontal;
            else
                return 0f;
        }
    }

    private float leftDirectional_Vertical;
    public float LeftDirectional_Vertical
    {
        get
        {
            if (Mathf.Abs(leftDirectional_Vertical) >= inputZeroThreshold)
                return leftDirectional_Vertical;
            else
                return 0f;
        }
    }

    private float rightDirectional_Horizontal;
    public float RightDirectional_Horizontal
    {
        get
        {
            if (Mathf.Abs(rightDirectional_Horizontal) >= inputZeroThreshold)
                return rightDirectional_Horizontal;
            else
                return 0f;
        }
    }

    private float rightDirectional_Vertical;
    public float RightDirectional_Vertical
    {
        get
        {
            if (Mathf.Abs(rightDirectional_Vertical) >= inputZeroThreshold)
                return rightDirectional_Vertical;
            else
                return 0f;
        }
    }
    //End of Directionals

    //Buttons ABXY
    public bool A_button_hold { get; private set; }
    public bool B_button_hold { get; private set; }
    public bool X_button_hold { get; private set; }
    public bool Y_button_hold { get; private set; }
    public bool A_button_down { get; private set; }
    public bool B_button_down { get; private set; }
    public bool X_button_down { get; private set; }
    public bool Y_button_down { get; private set; }
    public bool A_button_up { get; private set; }
    public bool B_button_up { get; private set; }
    public bool X_button_up { get; private set; }
    public bool Y_button_up { get; private set; }

    //Bumbers
    public bool LB_hold { get; private set; }
    public bool LB_down { get; private set; }
    public bool LB_up { get; private set; }
    public bool RB_hold { get; private set; }
    public bool RB_down { get; private set; }
    public bool RB_up { get; private set; }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Left Directional
            //Horizontal Axis
        leftDirectional_Horizontal = Input.GetAxis("Xb_LeftDir_H");
            //Vertical Axis
        leftDirectional_Vertical = Input.GetAxis("Xb_LeftDir_V");

        //Right Directional
            //Horizontal Axis
        rightDirectional_Horizontal = Input.GetAxis("Xb_RightDir_H");
            //Vertical Axis
        rightDirectional_Vertical = Input.GetAxis("Xb_RightDir_V");

        //ABXY
        A_button_hold = Input.GetButton("Xb_A");
        B_button_hold = Input.GetButton("Xb_B");
        X_button_hold = Input.GetButton("Xb_X");
        Y_button_hold = Input.GetButton("Xb_Y");
        A_button_down = Input.GetButtonDown("Xb_A");
        B_button_down = Input.GetButtonDown("Xb_B");
        X_button_down = Input.GetButtonDown("Xb_X");
        Y_button_down = Input.GetButtonDown("Xb_Y");
        A_button_up = Input.GetButtonUp("Xb_A");
        B_button_up = Input.GetButtonUp("Xb_B");
        X_button_up = Input.GetButtonUp("Xb_X");
        Y_button_up = Input.GetButtonUp("Xb_Y");

        //Bumpers
        LB_hold = Input.GetButton("Xb_LB");
        LB_down = Input.GetButtonDown("Xb_LB");
        LB_up = Input.GetButtonUp("Xb_LB");
        RB_hold = Input.GetButton("Xb_RB");
        RB_down = Input.GetButtonDown("Xb_RB");
        RB_up = Input.GetButtonUp("Xb_RB");

        //Checks every input and sets the active state of the controller, so that the user object don't have to check stuff every frame again.
        if (Mathf.Abs(leftDirectional_Horizontal) >= inputZeroThreshold || Mathf.Abs(leftDirectional_Vertical) >= inputZeroThreshold ||
            Mathf.Abs(rightDirectional_Horizontal) >= inputZeroThreshold || Mathf.Abs(rightDirectional_Vertical) >= inputZeroThreshold ||
            A_button_hold || A_button_down || A_button_up || B_button_hold || B_button_down || B_button_up ||
            X_button_hold || X_button_down || X_button_up || Y_button_hold || Y_button_down || Y_button_up ||
            LB_hold || LB_down || LB_up || RB_hold || RB_down || RB_up) 
        {
            IsInputActive = true;
        }
        else
        {
            IsInputActive = false;
        }

    }
}
