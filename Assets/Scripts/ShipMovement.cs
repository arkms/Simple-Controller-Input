using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour {

    public InputMapping inputMap;
    private Animator _animator;
    private Rigidbody2D rb;

    private bool canMove = false;

    // Use this for initialization
    void Awake () {
        _animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }
	
	// Update is called once per frame
	void Update () {

        //Reset position if falling off world
        if (this.transform.position.y < -7)
            this.transform.position = new Vector3(5, 10, 0);

        if (inputMap.ChangeToAlien())
        {
            rb.rotation = 0f;
            canMove = false;
            _animator.Play(Animator.StringToHash("ShipIdle"));
            rb.isKinematic = false;
            rb.freezeRotation = true;
        }
        else if (inputMap.ChangeToShip())
        {
            _animator.Play(Animator.StringToHash("Fly"));
            canMove = true;
            rb.isKinematic = true;
            rb.freezeRotation = false;
        }

        if (canMove)
        {
            if (inputMap.GoUp())
            {
                rb.rotation = 0f;
                transform.Translate(Vector2.up * 0.05f, Space.World);
            }
            else if (inputMap.GoDown())
            {
                rb.rotation = 0f;
                transform.Translate(Vector2.down * 0.05f, Space.World);
            }

            if (inputMap.GoLeft())
            {
                rb.rotation = 8f;
                transform.Translate(Vector2.left * 0.05f, Space.World);
            }
            else if (inputMap.GoRight())
            {
                rb.rotation = -8f;
                transform.Translate(Vector2.right * 0.05f, Space.World);
            }
            else if (inputMap.GoHorizontalAnalog() != 0f)
            {
                float speed = inputMap.GoHorizontalAnalog();
                transform.Translate(Vector2.right * 0.06f * speed, Space.World);
                rb.rotation = speed * -8;
            }
            else
            {
                rb.rotation = 0f;
            }
        }

    }
}
