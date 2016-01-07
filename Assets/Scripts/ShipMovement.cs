using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour {

    private InputMapping inputMap;
    private Animator _animator;
    private Rigidbody2D rb;
    public Rigidbody2D coinPrefab;

    private bool canMove = false;

    // Initialization
    void Awake () {
        _animator = GetComponent<Animator>();
        inputMap = GameObject.Find("Input Manager").GetComponent<InputMapping>();
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }
	
	// Check inputs every frame
	void Update () {

        //Reset position if falling off world
        if (this.transform.position.y < -7)
            this.transform.position = new Vector3(5, 10, 0);

        //Character swapping
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

        //Movement and Actions
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

            if(inputMap.ShootCoinDown())
            {
                Rigidbody2D coinInstance;
                coinInstance = Instantiate(coinPrefab, (this.transform.position + new Vector3(0, -1f, 0)), this.transform.rotation) as Rigidbody2D;
                coinInstance.AddForce(-5 * rb.transform.up, ForceMode2D.Impulse);
            }

            if (inputMap.ShootCoinUp())
            {
                Rigidbody2D coinInstance;
                coinInstance = Instantiate(coinPrefab, (this.transform.position + new Vector3(0, 1f, 0)), this.transform.rotation) as Rigidbody2D;
                coinInstance.AddForce(5 * rb.transform.up, ForceMode2D.Impulse);
            }
        }

    }
}
