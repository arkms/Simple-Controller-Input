using UnityEngine;
using System.Collections;

public class DestroyCoin : MonoBehaviour {

	// Destroys coin 3 seconds after it was spawn.
	void Start () {
        Destroy(gameObject, 3);
    }
}
