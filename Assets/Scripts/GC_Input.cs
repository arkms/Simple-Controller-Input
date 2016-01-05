using UnityEngine;
using System.Collections;

public class GC_Input : MonoBehaviour {

    //Variables
    /*
    > Floats:
    LeftDirectional_Horizontal
    LeftDirectional_Vertical
    RightDirectional_Horizontal
    RightDirectional_Vertical
    BothTriggers
    LeftTrigger
    RightTrigger

    > Digitals:
    LeftDirectional_asLeftButton
    LeftDirectional_asRightButton
    LeftDirectional_asUpButton
    LeftDirectional_asDownButton
    RightDirectional_asLeftButton
    RightDirectional_asRightButton
    RightDirectional_asUpButton
    RightDirectional_asDownButton
    LeftTrigger_asButton
    RightTrigger_asButton
    DPad_Left
    DPad_Right
    DPad_Up
    DPad_Down
    A_button_hold
    B_button_hold
    X_button_hold
    Y_button_hold
    A_button_down
    B_button_down
    X_button_down
    Y_button_down
    A_button_up
    B_button_up
    X_button_up
    Y_button_up
    LB_hold
    LB_down
    LB_up
    RB_hold
    RB_down
    RB_up
    LeftDir_press_hold
    LeftDir_press_down
    LeftDir_press_up
    RightDir_press_hold
    RightDir_press_down
    RightDir_press_up
    Start_hold
    Start_down
    Start_up
    Back_hold
    Back_down
    Back_up
    */

    //[SerializeField]
    private float inputZeroThreshold = 0.05f;
    private float inputDigitalThreshold = 0.25f;
    public bool IsInputActive { get; private set; }

    #region Left and Right Directionals
    private float leftDirectional_Horizontal = 0f;
    /// <summary>
    /// Returns an analog value from -1 (Left Directional completely to the LEFT) to 1 (Left Directional completely to the RIGHT), returning 0 when in the middle.
    /// </summary>
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

    private bool leftDirectional_asLeftButton;
    /// <summary>
    /// Returns TRUE while Left Directional is moved to the LEFT (past the threshold). Returns FALSE when released.
    /// </summary>
    public bool LeftDirectional_asLeftButton
    {
        get
        {
            if (leftDirectional_Horizontal <= -inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    private bool leftDirectional_asRightButton;
    /// <summary>
    /// Returns TRUE while Left Directional is moved to the RIGHT (past the threshold). Returns FALSE when released.
    /// </summary>
    public bool LeftDirectional_asRightButton
    {
        get
        {
            if (leftDirectional_Horizontal >= inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    private float leftDirectional_Vertical = 0f;
    /// <summary>
    /// Returns an analog value from -1 (Left Directional completely to the TOP) to 1 (Left Directional completely to the BOTTOM), returning 0 when in the middle.
    /// </summary>
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

    private bool leftDirectional_asUpButton;
    /// <summary>
    /// Returns TRUE while Left Directional is moved to the TOP (past the threshold). Returns FALSE when released.
    /// </summary>
    public bool LeftDirectional_asUpButton
    {
        get
        {
            if (leftDirectional_Vertical <= -inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    private bool leftDirectional_asDownButton;
    /// <summary>
    /// Returns TRUE while Left Directional is moved to the BOTTOM (past the threshold). Returns FALSE when released.
    /// </summary>
    public bool LeftDirectional_asDownButton
    {
        get
        {
            if (leftDirectional_Vertical >= inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    private float rightDirectional_Horizontal = 0f;
    /// <summary>
    /// Returns an analog value from -1 (Right Directional completely to the LEFT) to 1 (Rightt Directional completely to the RIGHT), returning 0 when in the middle.
    /// </summary>
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

    private bool rightDirectional_asLeftButton;
    /// <summary>
    /// Returns TRUE while Right Directional is moved to the LEFT (past the threshold). Returns FALSE when released.
    /// </summary>
    public bool RightDirectional_asLeftButton
    {
        get
        {
            if (rightDirectional_Horizontal <= -inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    private bool rightDirectional_asRightButton;
    /// <summary>
    /// Returns TRUE while Rightt Directional is moved to the RIGHT (past the threshold). Returns FALSE when released.
    /// </summary>
    public bool RightDirectional_asRightButton
    {
        get
        {
            if (rightDirectional_Horizontal >= inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    private float rightDirectional_Vertical = 0f;
    /// <summary>
    /// Returns an analog value from -1 (Right Directional completely to the TOP) to 1 (Right Directional completely to the BOTTOM), returning 0 when in the middle.
    /// </summary>
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

    private bool rightDirectional_asUpButton;
    /// <summary>
    /// Returns TRUE while Rightt Directional is moved to the TOP (past the threshold). Returns FALSE when released.
    /// </summary>
    public bool RightDirectional_asUpButton
    {
        get
        {
            if (rightDirectional_Vertical <= -inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    private bool rightDirectional_asDownButton;
    /// <summary>
    /// Returns TRUE while Rightt Directional is moved to the BOTTOM (past the threshold). Returns FALSE when released.
    /// </summary>
    public bool RightDirectional_asDownButton
    {
        get
        {
            if (rightDirectional_Vertical >= inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }
    #endregion

    #region Triggers

    private float bothTriggers = 0f;
    public float BothTriggers
    {
        get
        {
            if (bothTriggers >= inputZeroThreshold)
                return bothTriggers;
            else
                return 0f;
        }
    }

    private float leftTrigger = 0f;
    public float LeftTrigger
    {
        get
        {
            if (leftTrigger >= inputZeroThreshold)
                return leftTrigger;
            else
                return 0f;
        }
    }

    private float rightTrigger = 0f;
    public float RightTrigger
    {
        get
        {
            if (Mathf.Abs(rightTrigger) >= inputZeroThreshold)
                return rightTrigger;
            else
                return 0f;
        }
    }

    private bool leftTrigger_asButton;
    public bool LeftTrigger_asButton
    {
        get
        {
            if (leftTrigger >= inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    private bool rightTrigger_asButton;
    public bool RightTrigger_asButton
    {
        get
        {
            if (rightTrigger >= inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }
    #endregion

    #region DPADs
    private float dPad_Horizontal;
    public bool DPad_Left
    {
        get
        {
            if (dPad_Horizontal < -inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    public bool DPad_Right
    {
        get
        {
            if (dPad_Horizontal > inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    private float dPad_Vertical;
    public bool DPad_Up
    {
        get
        {
            if (dPad_Vertical > inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    public bool DPad_Down
    {
        get
        {
            if (dPad_Vertical < -inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }
    #endregion

    #region Buttons ABXY
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
    #endregion

    #region Bumbers
    public bool LB_hold { get; private set; }
    public bool LB_down { get; private set; }
    public bool LB_up { get; private set; }
    public bool RB_hold { get; private set; }
    public bool RB_down { get; private set; }
    public bool RB_up { get; private set; }
    #endregion

    #region Directional Press
    public bool LeftDir_press_hold { get; private set; }
    public bool LeftDir_press_down { get; private set; }
    public bool LeftDir_press_up { get; private set; }
    public bool RightDir_press_hold { get; private set; }
    public bool RightDir_press_down { get; private set; }
    public bool RightDir_press_up { get; private set; }
    #endregion

    #region Start and Back Buttons
    public bool Start_hold { get; private set; }
    public bool Start_down { get; private set; }
    public bool Start_up { get; private set; }
    public bool Back_hold { get; private set; }
    public bool Back_down { get; private set; }
    public bool Back_up { get; private set; }
    #endregion

    // Keep object alive in every scene
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Check for controller inputs
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

        //Triggers
        bothTriggers = Input.GetAxis("Xb_Triggers");
        leftTrigger = Input.GetAxis("Xb_LeftTrigger");
        rightTrigger = Input.GetAxis("Xb_RightTrigger");

        //Bumpers
        LB_hold = Input.GetButton("Xb_LB");
        LB_down = Input.GetButtonDown("Xb_LB");
        LB_up = Input.GetButtonUp("Xb_LB");
        RB_hold = Input.GetButton("Xb_RB");
        RB_down = Input.GetButtonDown("Xb_RB");
        RB_up = Input.GetButtonUp("Xb_RB");

        //Directional Press
        LeftDir_press_hold = Input.GetButton("Xb_LeftDir_press");
        LeftDir_press_down = Input.GetButtonDown("Xb_LeftDir_press");
        LeftDir_press_up = Input.GetButtonUp("Xb_LeftDir_press");
        RightDir_press_hold = Input.GetButton("Xb_RightDir_press");
        RightDir_press_down = Input.GetButtonDown("Xb_RightDir_press");
        RightDir_press_up = Input.GetButtonUp("Xb_RightDir_press");

        //DPads
        dPad_Horizontal = Input.GetAxis("Xb_DPad_H");
        dPad_Vertical = Input.GetAxis("Xb_DPad_V");

        //Start and Back
        Start_hold = Input.GetButton("Xb_Start");
        Start_down = Input.GetButtonDown("Xb_Start");
        Start_up = Input.GetButtonUp("Xb_Start");
        Back_hold = Input.GetButton("Xb_Back");
        Back_down = Input.GetButtonDown("Xb_Back");
        Back_up = Input.GetButtonUp("Xb_Back");

        //Checks every input and sets the active state of the controller, so that the user object don't have to check stuff every frame again.
        if (Mathf.Abs(leftDirectional_Horizontal) >= inputZeroThreshold || Mathf.Abs(leftDirectional_Vertical) >= inputZeroThreshold ||
            Mathf.Abs(rightDirectional_Horizontal) >= inputZeroThreshold || Mathf.Abs(rightDirectional_Vertical) >= inputZeroThreshold ||
            A_button_hold || A_button_down || A_button_up || B_button_hold || B_button_down || B_button_up ||
            X_button_hold || X_button_down || X_button_up || Y_button_hold || Y_button_down || Y_button_up ||
            leftTrigger >= inputZeroThreshold || rightTrigger >= inputZeroThreshold ||
            LB_hold || LB_down || LB_up || RB_hold || RB_down || RB_up ||
            LeftDir_press_hold || LeftDir_press_down || LeftDir_press_up || RightDir_press_hold || RightDir_press_down || RightDir_press_up ||
            Mathf.Abs(dPad_Horizontal) >= inputZeroThreshold || Mathf.Abs(dPad_Vertical) >= inputZeroThreshold ||
            Start_hold || Start_down || Start_up || Back_hold || Back_down || Back_up)
        {
            IsInputActive = true;
        }
        else
        {
            IsInputActive = false;
        }

    }
}
