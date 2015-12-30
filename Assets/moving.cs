using UnityEngine;
using System.Collections;

public class moving : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Xb_LeftDir_H") >= 0.1 || Input.GetAxis("Xb_LeftDir_H") <= -0.1)
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
        }
    }
}
