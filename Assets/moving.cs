using UnityEngine;
using System.Collections;

public class moving : MonoBehaviour {

    public GC_Input X_input;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (X_input.IsInputActive)
        {
            this.transform.Rotate(Vector3.forward * 100 * Time.deltaTime);
            //print(X_input.LeftDir_H);
        }
    }
}
