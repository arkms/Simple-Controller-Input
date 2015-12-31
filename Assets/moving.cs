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
            //print(controllerInput.DPad_Up);
            print(controllerInput.Start_up);


        }
    }
}
