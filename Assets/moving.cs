using UnityEngine;
using System.Collections;

public class moving : MonoBehaviour {

    public GC_Input controllerInput;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (controllerInput.IsInputActive)
        {
            if(controllerInput.X_button_hold)
                this.transform.Rotate(Vector3.up * -100 * Time.deltaTime);
            if (controllerInput.B_button_hold)
                this.transform.Rotate(Vector3.up * 100 * Time.deltaTime);

            if (controllerInput.A_button_hold)
                this.transform.Rotate(Vector3.right * 100 * Time.deltaTime);
            if (controllerInput.Y_button_hold)
                this.transform.Rotate(Vector3.right * -100 * Time.deltaTime);

            if (controllerInput.LB_hold)
                this.transform.Rotate(Vector3.forward * 100 * Time.deltaTime);
            if (controllerInput.RB_hold)
                this.transform.Rotate(Vector3.forward * -100 * Time.deltaTime);
            //print(" " + controllerInput.LeftDirectional_Vertical + " " + controllerInput.RightDirectional_Horizontal + " " + controllerInput.RightDirectional_Vertical);
            //print(controllerInput.A_button_hold + " " + controllerInput.A_button_down + " " + controllerInput.A_button_up + " " +
            //    controllerInput.B_button_hold + " " + controllerInput.B_button_down + " " + controllerInput.B_button_up + " !");
        }
    }
}
