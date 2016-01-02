using UnityEngine;
using System.Collections;

public class AutoCameraSize : MonoBehaviour {

    [SerializeField]
    private Camera thisCamera;
	// Use this for initialization
	void Start () {

        if (thisCamera.orthographic)
        {
            //screenSizeOrto = 510 * Screen.height / Screen.width;
            //thisCamera.orthographicSize = Screen.height / 2;
            thisCamera.orthographicSize = 9.6f * Screen.height / Screen.width;
        }
	}

}
