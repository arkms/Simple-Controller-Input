using UnityEngine;
using System.Collections;

public class GC_Input : MonoBehaviour {

    private float inputZeroThreshold = 0.05f;
    private float inputDigitalThreshold = 0.5f;
    private float leftDir_H;

    public bool IsInputActive { get; set; }

    public float LeftDir_H {
        get
        {
            if (Mathf.Abs(leftDir_H) >= inputZeroThreshold)
                return leftDir_H;
            else
                return 0f;
        }
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        leftDir_H = Input.GetAxis("Xb_LeftDir_H");



        //Checks every input and sets the active state of the controller, so that the user object don't have to check stuff every frame again.
        if (Mathf.Abs(leftDir_H) >= inputZeroThreshold)
        {
            IsInputActive = true;
        }
        else
        {
            IsInputActive = false;
        }

        /*if (Input.GetAxis("Xb_LeftDir_H") >= 0.1 || Input.GetAxis("Xb_LeftDir_H") <= -0.1)
        {

            //Debug.Log(Input.GetAxis("Xb_LeftDir_H"));
        }

        this.transform.Translate(new Vector3(Input.GetAxis("Xb_LeftDir_H"), -Input.GetAxis("Xb_LeftDir_V"), 0) * 20 * Time.deltaTime);
        this.transform.Translate(new Vector3(Input.GetAxis("Xb_RightDir_H"), -Input.GetAxis("Xb_RightDir_V"), 0) * 50 * Time.deltaTime);

        if (Input.GetButtonDown("Xb_A"))
        {
            Debug.Log("A");
        }
        if (Input.GetButtonDown("Xb_B"))
        {
            Debug.Log("B");
        }
        if (Input.GetButtonDown("Xb_X"))
        {
            Debug.Log("X");
        }
        if (Input.GetButtonDown("Xb_Y"))
        {
            Debug.Log("Y");
        }*/
    }
}
