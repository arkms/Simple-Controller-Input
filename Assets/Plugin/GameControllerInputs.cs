using UnityEngine;
using System.Collections;

public class GameControllerInputs : MonoBehaviour {

    //Variables

    /*
    Below, you can find a list of all inputs available:

 > ANALOG (returns a float):
    LeftDirectional_Horizontal  (returns: 0 to -1 <left>; 0 to 1 <right>)
    LeftDirectional_Vertical    (returns: 0 to -1 <up>; 0 to 1 <down>)

    RightDirectional_Horizontal (returns: 0 to -1 <left>; 0 to 1 <right>)
    RightDirectional_Vertical   (returns: 0 to -1 <up>; 0 to 1 <down>)

    BothTriggers                (returns: -1 to 1 <depends on the combination of both triggers>)
    LeftTrigger                 (returns: 0 to 1)
    RightTrigger                (returns: 0 to 1)

 > DIGITAL (returns a boolean - true when pressed):
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
    A_button_down
    A_button_up
    
    B_button_hold
    B_button_down
    B_button_up
    
    X_button_hold
    X_button_down
    X_button_up
    
    Y_button_hold
    Y_button_down
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

    private float inputZeroThreshold = 0.05f;           //Filters small value fluctuations when the analog inputs are released.
    private float inputDigitalThreshold = 0.25f;        //Minimum value that an analog input can be considered active when used as a digital button.
    public bool IsInputActive { get; private set; }     //True when any input is active.
    public bool IsInputActive2 { get; private set; }     //True when any input is active.

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
        /// Returns TRUE while Left Directional is moved to the LEFT (past the threshold). Returns FALSE while released.
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
        /// Returns TRUE while Left Directional is moved to the RIGHT (past the threshold). Returns FALSE while released.
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
        /// Returns TRUE while Left Directional is moved to the TOP (past the threshold). Returns FALSE while released.
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
        /// Returns TRUE while Left Directional is moved to the BOTTOM (past the threshold). Returns FALSE while released.
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
        /// Returns TRUE while Right Directional is moved to the LEFT (past the threshold). Returns FALSE while released.
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
        /// Returns TRUE while Right Directional is moved to the RIGHT (past the threshold). Returns FALSE while released.
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
        /// Returns TRUE while Right Directional is moved to the TOP (past the threshold). Returns FALSE while released.
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
        /// Returns TRUE while Right Directional is moved to the BOTTOM (past the threshold). Returns FALSE while released.
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

    #region Left and Right Directionals2
    private float leftDirectional_Horizontal2 = 0f;
    /// <summary>
    /// Returns an analog value from -1 (Left Directional completely to the LEFT) to 1 (Left Directional completely to the RIGHT), returning 0 when in the middle.
    /// </summary>
    public float LeftDirectional_Horizontal2
    {
        get
        {
            if (Mathf.Abs(leftDirectional_Horizontal2) >= inputZeroThreshold)
                return leftDirectional_Horizontal2;
            else
                return 0f;
        }
    }

    private bool leftDirectional_asLeftButton2;
    /// <summary>
    /// Returns TRUE while Left Directional is moved to the LEFT (past the threshold). Returns FALSE while released.
    /// </summary>
    public bool LeftDirectional_asLeftButton2
    {
        get
        {
            if (leftDirectional_Horizontal2 <= -inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    private bool leftDirectional_asRightButton2;
    /// <summary>
    /// Returns TRUE while Left Directional is moved to the RIGHT (past the threshold). Returns FALSE while released.
    /// </summary>
    public bool LeftDirectional_asRightButton2
    {
        get
        {
            if (leftDirectional_Horizontal2 >= inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    private float leftDirectional_Vertical2 = 0f;
    /// <summary>
    /// Returns an analog value from -1 (Left Directional completely to the TOP) to 1 (Left Directional completely to the BOTTOM), returning 0 when in the middle.
    /// </summary>
    public float LeftDirectional_Vertical2
    {
        get
        {
            if (Mathf.Abs(leftDirectional_Vertical2) >= inputZeroThreshold)
                return leftDirectional_Vertical2;
            else
                return 0f;
        }
    }

    private bool leftDirectional_asUpButton2;
    /// <summary>
    /// Returns TRUE while Left Directional is moved to the TOP (past the threshold). Returns FALSE while released.
    /// </summary>
    public bool LeftDirectional_asUpButton2
    {
        get
        {
            if (leftDirectional_Vertical2 <= -inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    private bool leftDirectional_asDownButton2;
    /// <summary>
    /// Returns TRUE while Left Directional is moved to the BOTTOM (past the threshold). Returns FALSE while released.
    /// </summary>
    public bool LeftDirectional_asDownButton2
    {
        get
        {
            if (leftDirectional_Vertical2 >= inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    private float rightDirectional_Horizontal2 = 0f;
    /// <summary>
    /// Returns an analog value from -1 (Right Directional completely to the LEFT) to 1 (Rightt Directional completely to the RIGHT), returning 0 when in the middle.
    /// </summary>
    public float RightDirectional_Horizontal2
    {
        get
        {
            if (Mathf.Abs(rightDirectional_Horizontal2) >= inputZeroThreshold)
                return rightDirectional_Horizontal2;
            else
                return 0f;
        }
    }

    private bool rightDirectional_asLeftButton2;
    /// <summary>
    /// Returns TRUE while Right Directional is moved to the LEFT (past the threshold). Returns FALSE while released.
    /// </summary>
    public bool RightDirectional_asLeftButton2
    {
        get
        {
            if (rightDirectional_Horizontal2 <= -inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    private bool rightDirectional_asRightButton2;
    /// <summary>
    /// Returns TRUE while Right Directional is moved to the RIGHT (past the threshold). Returns FALSE while released.
    /// </summary>
    public bool RightDirectional_asRightButton2
    {
        get
        {
            if (rightDirectional_Horizontal2 >= inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    private float rightDirectional_Vertical2 = 0f;
    /// <summary>
    /// Returns an analog value from -1 (Right Directional completely to the TOP) to 1 (Right Directional completely to the BOTTOM), returning 0 when in the middle.
    /// </summary>
    public float RightDirectional_Vertical2
    {
        get
        {
            if (Mathf.Abs(rightDirectional_Vertical2) >= inputZeroThreshold)
                return rightDirectional_Vertical2;
            else
                return 0f;
        }
    }

    private bool rightDirectional_asUpButton2;
    /// <summary>
    /// Returns TRUE while Right Directional is moved to the TOP (past the threshold). Returns FALSE while released.
    /// </summary>
    public bool RightDirectional_asUpButton2
    {
        get
        {
            if (rightDirectional_Vertical2 <= -inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    private bool rightDirectional_asDownButton2;
    /// <summary>
    /// Returns TRUE while Right Directional is moved to the BOTTOM (past the threshold). Returns FALSE while released.
    /// </summary>
    public bool RightDirectional_asDownButton2
    {
        get
        {
            if (rightDirectional_Vertical2 >= inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }
    #endregion


    #region Triggers
    private float bothTriggers = 0f;
        /// <summary>
        /// Returns an analog value from -1 to 1 that is a combination from the Left Trigger (0 to 1) and the Right Trigger (0 to -1). It returns 0 if both triggers are released (0 + 0) or fully pressed (-1 + 1).
        /// </summary>
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
        /// <summary>
        /// Returns an analog value from 0 (Trigger released) to 1 (Trigger fully pressed).
        /// </summary>
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
        /// <summary>
        /// Returns an analog value from 0 (Trigger released) to 1 (Trigger fully pressed).
        /// </summary>
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
        /// <summary>
        /// Returns TRUE while the Left Trigger is being pressed (past the threshold). Returns FALSE while released.
        /// </summary>
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
        /// <summary>
        /// Returns TRUE while the Right Trigger is being pressed (past the threshold). Returns FALSE while released.
        /// </summary>
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

    #region Triggers2
    private float bothTriggers2 = 0f;
    /// <summary>
    /// Returns an analog value from -1 to 1 that is a combination from the Left Trigger (0 to 1) and the Right Trigger (0 to -1). It returns 0 if both triggers are released (0 + 0) or fully pressed (-1 + 1).
    /// </summary>
    public float BothTriggers2
    {
        get
        {
            if (bothTriggers2 >= inputZeroThreshold)
                return bothTriggers2;
            else
                return 0f;
        }
    }

    private float leftTrigger2 = 0f;
    /// <summary>
    /// Returns an analog value from 0 (Trigger released) to 1 (Trigger fully pressed).
    /// </summary>
    public float LeftTrigger2
    {
        get
        {
            if (leftTrigger2 >= inputZeroThreshold)
                return leftTrigger2;
            else
                return 0f;
        }
    }

    private float rightTrigger2 = 0f;
    /// <summary>
    /// Returns an analog value from 0 (Trigger released) to 1 (Trigger fully pressed).
    /// </summary>
    public float RightTrigger2
    {
        get
        {
            if (Mathf.Abs(rightTrigger2) >= inputZeroThreshold)
                return rightTrigger2;
            else
                return 0f;
        }
    }

    private bool leftTrigger_asButton2;
    /// <summary>
    /// Returns TRUE while the Left Trigger is being pressed (past the threshold). Returns FALSE while released.
    /// </summary>
    public bool LeftTrigger_asButton2
    {
        get
        {
            if (leftTrigger2 >= inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    private bool rightTrigger_asButton2;
    /// <summary>
    /// Returns TRUE while the Right Trigger is being pressed (past the threshold). Returns FALSE while released.
    /// </summary>
    public bool RightTrigger_asButton2
    {
        get
        {
            if (rightTrigger2 >= inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }
    #endregion


    #region DPADs
    private float dPad_Horizontal;
        /// <summary>
        /// Returns TRUE while the DPad's Left direction is being pressed. Returns FALSE while released.
        /// </summary>
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
        /// <summary>
        /// Returns TRUE while the DPad's Right direction is being pressed. Returns FALSE while released.
        /// </summary>
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
        /// <summary>
        /// Returns TRUE while the DPad's Up direction is being pressed. Returns FALSE while released.
        /// </summary>
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
        /// <summary>
        /// Returns TRUE while the DPad's Down direction is being pressed. Returns FALSE while released.
        /// </summary>
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

    #region DPADs2
    private float dPad_Horizontal2;
    /// <summary>
    /// Returns TRUE while the DPad's Left direction is being pressed. Returns FALSE while released.
    /// </summary>
    public bool DPad_Left2
    {
        get
        {
            if (dPad_Horizontal2 < -inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }
    /// <summary>
    /// Returns TRUE while the DPad's Right direction is being pressed. Returns FALSE while released.
    /// </summary>
    public bool DPad_Right2
    {
        get
        {
            if (dPad_Horizontal2 > inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }

    private float dPad_Vertical2;
    /// <summary>
    /// Returns TRUE while the DPad's Up direction is being pressed. Returns FALSE while released.
    /// </summary>
    public bool DPad_Up2
    {
        get
        {
            if (dPad_Vertical2 > inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }
    /// <summary>
    /// Returns TRUE while the DPad's Down direction is being pressed. Returns FALSE while released.
    /// </summary>
    public bool DPad_Down2
    {
        get
        {
            if (dPad_Vertical2 < -inputDigitalThreshold)
                return true;
            else
                return false;
        }
    }
    #endregion


    #region Buttons ABXY
        /// <summary>
        /// Returns TRUE while the A button is being pressed. Returns FALSE while released.
        /// </summary>
        public bool A_button_hold { get; private set; }
        /// <summary>
        /// Returns TRUE while the B button is being pressed. Returns FALSE while released.
        /// </summary>
        public bool B_button_hold { get; private set; }
        /// <summary>
        /// Returns TRUE while the X button is being pressed. Returns FALSE while released.
        /// </summary>
        public bool X_button_hold { get; private set; }
        /// <summary>
        /// Returns TRUE while the Y button is being pressed. Returns FALSE while released.
        /// </summary>
        public bool Y_button_hold { get; private set; }
        /// <summary>
        /// Returns TRUE during the frame the A button was pressed.
        /// </summary>
        public bool A_button_down { get; private set; }
        /// <summary>
        /// Returns TRUE during the frame the B button was pressed.
        /// </summary>
        public bool B_button_down { get; private set; }
        /// <summary>
        /// Returns TRUE during the frame the X button was pressed.
        /// </summary>
        public bool X_button_down { get; private set; }
        /// <summary>
        /// Returns TRUE during the frame the Y button was pressed.
        /// </summary>
        public bool Y_button_down { get; private set; }
        /// <summary>
        /// Returns TRUE the first frame the A button was released.
        /// </summary>
        public bool A_button_up { get; private set; }
        /// <summary>
        /// Returns TRUE the first frame the B button was released.
        /// </summary>
        public bool B_button_up { get; private set; }
        /// <summary>
        /// Returns TRUE the first frame the X button was released.
        /// </summary>
        public bool X_button_up { get; private set; }
        /// <summary>
        /// Returns TRUE the first framer the Y button was released.
        /// </summary>
        public bool Y_button_up { get; private set; }
    #endregion

    #region Buttons ABXY2
    /// <summary>
    /// Returns TRUE while the A button is being pressed. Returns FALSE while released.
    /// </summary>
    public bool A_button_hold2 { get; private set; }
    /// <summary>
    /// Returns TRUE while the B button is being pressed. Returns FALSE while released.
    /// </summary>
    public bool B_button_hold2 { get; private set; }
    /// <summary>
    /// Returns TRUE while the X button is being pressed. Returns FALSE while released.
    /// </summary>
    public bool X_button_hold2 { get; private set; }
    /// <summary>
    /// Returns TRUE while the Y button is being pressed. Returns FALSE while released.
    /// </summary>
    public bool Y_button_hold2 { get; private set; }
    /// <summary>
    /// Returns TRUE during the frame the A button was pressed.
    /// </summary>
    public bool A_button_down2 { get; private set; }
    /// <summary>
    /// Returns TRUE during the frame the B button was pressed.
    /// </summary>
    public bool B_button_down2 { get; private set; }
    /// <summary>
    /// Returns TRUE during the frame the X button was pressed.
    /// </summary>
    public bool X_button_down2 { get; private set; }
    /// <summary>
    /// Returns TRUE during the frame the Y button was pressed.
    /// </summary>
    public bool Y_button_down2 { get; private set; }
    /// <summary>
    /// Returns TRUE the first frame the A button was released.
    /// </summary>
    public bool A_button_up2 { get; private set; }
    /// <summary>
    /// Returns TRUE the first frame the B button was released.
    /// </summary>
    public bool B_button_up2 { get; private set; }
    /// <summary>
    /// Returns TRUE the first frame the X button was released.
    /// </summary>
    public bool X_button_up2 { get; private set; }
    /// <summary>
    /// Returns TRUE the first framer the Y button was released.
    /// </summary>
    public bool Y_button_up2 { get; private set; }
    #endregion


    #region Bumbers
        /// <summary>
        /// Returns TRUE while the Left Bumper is being pressed. Returns FALSE while released.
        /// </summary>
        public bool LB_hold { get; private set; }
        /// <summary>
        /// Returns TRUE during the frame the Left Bumper was pressed.
        /// </summary>
        public bool LB_down { get; private set; }
        /// <summary>
        /// Returns TRUE the first frame the Left Bumper was released.
        /// </summary>
        public bool LB_up { get; private set; }
        /// <summary>
        /// Returns TRUE while the Right Bumper is being pressed. Returns FALSE while released.
        /// </summary>
        public bool RB_hold { get; private set; }
        /// <summary>
        /// Returns TRUE during the frame the Left Bumper was pressed.
        /// </summary>
        public bool RB_down { get; private set; }
        /// <summary>
        /// Returns TRUE the first frame the Right Bumper was released.
        /// </summary>
        public bool RB_up { get; private set; }
    #endregion

    #region Bumbers2
    /// <summary>
    /// Returns TRUE while the Left Bumper is being pressed. Returns FALSE while released.
    /// </summary>
    public bool LB_hold2 { get; private set; }
    /// <summary>
    /// Returns TRUE during the frame the Left Bumper was pressed.
    /// </summary>
    public bool LB_down2 { get; private set; }
    /// <summary>
    /// Returns TRUE the first frame the Left Bumper was released.
    /// </summary>
    public bool LB_up2 { get; private set; }
    /// <summary>
    /// Returns TRUE while the Right Bumper is being pressed. Returns FALSE while released.
    /// </summary>
    public bool RB_hold2 { get; private set; }
    /// <summary>
    /// Returns TRUE during the frame the Left Bumper was pressed.
    /// </summary>
    public bool RB_down2 { get; private set; }
    /// <summary>
    /// Returns TRUE the first frame the Right Bumper was released.
    /// </summary>
    public bool RB_up2 { get; private set; }
    #endregion


    #region Directional Press
        /// <summary>
        /// Returns TRUE while the Left Directional is being pressed down (click). Returns FALSE while released.
        /// </summary>
        public bool LeftDir_press_hold { get; private set; }
        /// <summary>
        /// Returns TRUE during the frame the Left Directional was pressed down (click).
        /// </summary>
        public bool LeftDir_press_down { get; private set; }
        /// <summary>
        /// Returns TRUE the first frame the Left Directional press (click) is released (click).
        /// </summary>
        public bool LeftDir_press_up { get; private set; }
        /// <summary>
        /// Returns TRUE while the Right Directional is being pressed down (click). Returns FALSE while released.
        /// </summary>
        public bool RightDir_press_hold { get; private set; }
        /// <summary>
        /// Returns TRUE during the frame the Right Directional was pressed down (click).
        /// </summary>
        public bool RightDir_press_down { get; private set; }
        /// <summary>
        /// Returns TRUE the first frame the Right Directional press (click) is released (click).
        /// </summary>
        public bool RightDir_press_up { get; private set; }
    #endregion

    #region Directional Press2
    /// <summary>
    /// Returns TRUE while the Left Directional is being pressed down (click). Returns FALSE while released.
    /// </summary>
    public bool LeftDir_press_hold2 { get; private set; }
    /// <summary>
    /// Returns TRUE during the frame the Left Directional was pressed down (click).
    /// </summary>
    public bool LeftDir_press_down2 { get; private set; }
    /// <summary>
    /// Returns TRUE the first frame the Left Directional press (click) is released (click).
    /// </summary>
    public bool LeftDir_press_up2 { get; private set; }
    /// <summary>
    /// Returns TRUE while the Right Directional is being pressed down (click). Returns FALSE while released.
    /// </summary>
    public bool RightDir_press_hold2 { get; private set; }
    /// <summary>
    /// Returns TRUE during the frame the Right Directional was pressed down (click).
    /// </summary>
    public bool RightDir_press_down2 { get; private set; }
    /// <summary>
    /// Returns TRUE the first frame the Right Directional press (click) is released (click).
    /// </summary>
    public bool RightDir_press_up2 { get; private set; }
    #endregion


    #region Start and Back Buttons
        /// <summary>
        /// Returns TRUE while the Start button is being pressed. Returns FALSE while released.
        /// </summary>
        public bool Start_hold { get; private set; }
        /// <summary>
        /// Returns TRUE during the frame the Start button was pressed down.
        /// </summary>
        public bool Start_down { get; private set; }
        /// <summary>
        /// Returns TRUE the first frame the Start button press is released.
        /// </summary>
        public bool Start_up { get; private set; }
        /// <summary>
        /// Returns TRUE while the Back button is being pressed. Returns FALSE while released.
        /// </summary>
        public bool Back_hold { get; private set; }
        /// <summary>
        /// Returns TRUE during the frame the Back button was pressed down.
        /// </summary>
        public bool Back_down { get; private set; }
        /// <summary>
        /// Returns TRUE the first frame the Back button press is released.
        /// </summary>
        public bool Back_up { get; private set; }
    #endregion

    #region Start and Back Buttons2
    /// <summary>
    /// Returns TRUE while the Start button is being pressed. Returns FALSE while released.
    /// </summary>
    public bool Start_hold2 { get; private set; }
    /// <summary>
    /// Returns TRUE during the frame the Start button was pressed down.
    /// </summary>
    public bool Start_down2 { get; private set; }
    /// <summary>
    /// Returns TRUE the first frame the Start button press is released.
    /// </summary>
    public bool Start_up2 { get; private set; }
    /// <summary>
    /// Returns TRUE while the Back button is being pressed. Returns FALSE while released.
    /// </summary>
    public bool Back_hold2 { get; private set; }
    /// <summary>
    /// Returns TRUE during the frame the Back button was pressed down.
    /// </summary>
    public bool Back_down2 { get; private set; }
    /// <summary>
    /// Returns TRUE the first frame the Back button press is released.
    /// </summary>
    public bool Back_up2 { get; private set; }
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


        //Player2----------------------------------------------------------------------------------------------------------------
        //Left Directional
        //Horizontal Axis
        leftDirectional_Horizontal2 = Input.GetAxis("Xb_LeftDir_H2");
        //Vertical Axis
        leftDirectional_Vertical2 = Input.GetAxis("Xb_LeftDir_V2");

        //Right Directional
        //Horizontal Axis
        rightDirectional_Horizontal2 = Input.GetAxis("Xb_RightDir_H2");
        //Vertical Axis
        rightDirectional_Vertical2 = Input.GetAxis("Xb_RightDir_V2");

        //ABXY
        A_button_hold2 = Input.GetButton("Xb_A2");
        B_button_hold2 = Input.GetButton("Xb_B2");
        X_button_hold2 = Input.GetButton("Xb_X2");
        Y_button_hold2 = Input.GetButton("Xb_Y2");
        A_button_down2 = Input.GetButtonDown("Xb_A2");
        B_button_down2 = Input.GetButtonDown("Xb_B2");
        X_button_down2 = Input.GetButtonDown("Xb_X2");
        Y_button_down2 = Input.GetButtonDown("Xb_Y2");
        A_button_up2 = Input.GetButtonUp("Xb_A2");
        B_button_up2 = Input.GetButtonUp("Xb_B2");
        X_button_up2 = Input.GetButtonUp("Xb_X2");
        Y_button_up2 = Input.GetButtonUp("Xb_Y2");

        //Triggers
        bothTriggers2 = Input.GetAxis("Xb_Triggers2");
        leftTrigger2 = Input.GetAxis("Xb_LeftTrigger2");
        rightTrigger2 = Input.GetAxis("Xb_RightTrigger2");

        //Bumpers
        LB_hold2 = Input.GetButton("Xb_LB2");
        LB_down2 = Input.GetButtonDown("Xb_LB2");
        LB_up2 = Input.GetButtonUp("Xb_LB2");
        RB_hold2 = Input.GetButton("Xb_RB2");
        RB_down2 = Input.GetButtonDown("Xb_RB2");
        RB_up2 = Input.GetButtonUp("Xb_RB2");

        //Directional Press
        LeftDir_press_hold2 = Input.GetButton("Xb_LeftDir_press2");
        LeftDir_press_down2 = Input.GetButtonDown("Xb_LeftDir_press2");
        LeftDir_press_up2 = Input.GetButtonUp("Xb_LeftDir_press2");
        RightDir_press_hold2 = Input.GetButton("Xb_RightDir_press2");
        RightDir_press_down2 = Input.GetButtonDown("Xb_RightDir_press2");
        RightDir_press_up2 = Input.GetButtonUp("Xb_RightDir_press2");

        //DPads
        dPad_Horizontal2 = Input.GetAxis("Xb_DPad_H2");
        dPad_Vertical2 = Input.GetAxis("Xb_DPad_V2");

        //Start and Back
        Start_hold2 = Input.GetButton("Xb_Start2");
        Start_down2 = Input.GetButtonDown("Xb_Start2");
        Start_up2 = Input.GetButtonUp("Xb_Start2");
        Back_hold2 = Input.GetButton("Xb_Back2");
        Back_down2 = Input.GetButtonDown("Xb_Back2");
        Back_up2 = Input.GetButtonUp("Xb_Back2");


        //Checks every input and sets the active state of the controller, so that the user object don't have to check stuff every frame again.
        if (Mathf.Abs(leftDirectional_Horizontal2) >= inputZeroThreshold || Mathf.Abs(leftDirectional_Vertical2) >= inputZeroThreshold ||
            Mathf.Abs(rightDirectional_Horizontal2) >= inputZeroThreshold || Mathf.Abs(rightDirectional_Vertical2) >= inputZeroThreshold ||
            A_button_hold2 || A_button_down2 || A_button_up2 || B_button_hold2 || B_button_down2 || B_button_up2 ||
            X_button_hold2 || X_button_down2 || X_button_up2 || Y_button_hold2 || Y_button_down2 || Y_button_up2 ||
            leftTrigger2 >= inputZeroThreshold || rightTrigger2 >= inputZeroThreshold ||
            LB_hold2 || LB_down2 || LB_up2 || RB_hold2 || RB_down2 || RB_up2 ||
            LeftDir_press_hold2 || LeftDir_press_down2 || LeftDir_press_up2 || RightDir_press_hold2 || RightDir_press_down2 || RightDir_press_up2 ||
            Mathf.Abs(dPad_Horizontal2) >= inputZeroThreshold || Mathf.Abs(dPad_Vertical2) >= inputZeroThreshold ||
            Start_hold2 || Start_down2 || Start_up2 || Back_hold2 || Back_down2 || Back_up2)
        {
            IsInputActive2 = true;
        }
        else
        {
            IsInputActive2 = false;
        }

    }

	//Singleton-----------------------
	static GameControllerInputs instance;
	//Return reference of instance of GameController
	public static GameControllerInputs GetIstance()
	{
		return instance;
	}

	[RuntimeInitializeOnLoadMethod]
	static void OnLoad()
	{
		//Create gameObject
		GameObject go = new GameObject("GameControllerInput");
		instance= go.AddComponent<GameControllerInputs>();
	}
}
