using UnityEngine;
using System.Collections;
using Prime31;


public class PlayerMovement : MonoBehaviour
{
	// movement config
	public float gravity = -25f;
	public float runSpeed = 8f;
	public float groundDamping = 20f; // how fast do we change direction? higher means faster
	public float inAirDamping = 5f;
	public float jumpHeight = 3f;
    public InputMapping inputMap;
    private bool canMove = true;

    [HideInInspector]
	private float normalizedHorizontalSpeed = 0;

    private bool canClimb;
    private bool isClimbing;
    private bool isAttacking;
	private CharacterController2D _controller;
	private Animator _animator;
	private RaycastHit2D _lastControllerColliderHit;
	private Vector3 _velocity;
    


	void Awake()
	{
		_animator = GetComponent<Animator>();
		_controller = GetComponent<CharacterController2D>();

		// listen to some events for illustration purposes
		_controller.onControllerCollidedEvent += onControllerCollider;
		_controller.onTriggerEnterEvent += onTriggerEnterEvent;
		_controller.onTriggerExitEvent += onTriggerExitEvent;
	}


	#region Event Listeners

	void onControllerCollider( RaycastHit2D hit )
	{
		// bail out on plain old ground hits cause they arent very interesting
		if( hit.normal.y == 1f )
			return;

		// logs any collider hits if uncommented. it gets noisy so it is commented out for the demo
		//Debug.Log( "flags: " + _controller.collisionState + ", hit.normal: " + hit.normal );
	}


	void onTriggerEnterEvent( Collider2D col )
	{
		Debug.Log( "onTriggerEnterEvent: " + col.gameObject.name );
	}


	void onTriggerExitEvent( Collider2D col )
	{
		Debug.Log( "onTriggerExitEvent: " + col.gameObject.name );
	}

    #endregion

    void OnTriggerEnter2D (Collider2D stairs)
    {
        canClimb = true;

    }

    void OnTriggerExit2D(Collider2D stairs)
    {
        canClimb = false;
        isClimbing = false;
    }

    IEnumerator WaitAttack()
    {
        yield return new WaitForSeconds(0.3f);
        isAttacking = false;
    }

    // the Update loop contains a very simple example of moving the character around and controlling the animation
    void Update()
	{
        //Choose between Alien and Spaceship
        if (inputMap.ChangeToAlien())
        {
            canMove = true;
        }
        else if (inputMap.ChangeToShip())
        {
            canMove = false;
        }

        //Reset position if falling off world
        if (this.transform.position.y < -7)
            this.transform.position = new Vector3(0, 10, 0);

        if (canMove)
        {
            if (_controller.isGrounded)
                _velocity.y = 0;

            if (inputMap.GoRight())
            {
                normalizedHorizontalSpeed = 1;
                if (transform.localScale.x < 0f)
                    transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);

                if (_controller.isGrounded && !isAttacking)
                    _animator.Play(Animator.StringToHash("Run"));
            }
            else if (inputMap.GoLeft())
            {
                normalizedHorizontalSpeed = -1;
                if (transform.localScale.x > 0f)
                    transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);

                if (_controller.isGrounded && !isAttacking)
                    _animator.Play(Animator.StringToHash("Run"));
            }
            else if (inputMap.GoHorizontalAnalog() != 0f)
            {
                normalizedHorizontalSpeed = inputMap.GoHorizontalAnalog();

                transform.localScale = new Vector3(Mathf.Sign(normalizedHorizontalSpeed), transform.localScale.y, transform.localScale.z);

                if (_controller.isGrounded && !isAttacking)
                    _animator.Play(Animator.StringToHash("Run"));
            }
            else
            {
                normalizedHorizontalSpeed = 0;

                if (_controller.isGrounded && !isAttacking)
                    _animator.Play(Animator.StringToHash("Idle"));
            }

            if (inputMap.AttackNow() && !isAttacking)
            {
                isAttacking = true;
                StartCoroutine(WaitAttack());
                _animator.Play(Animator.StringToHash("Attack"));
            }

            // we can only jump whilst grounded
            if ((_controller.isGrounded || isClimbing) && inputMap.JumpNow())
            {
                _velocity.y = Mathf.Sqrt(2f * jumpHeight * -gravity);
                _animator.Play(Animator.StringToHash("Jump"));
            }

            //Climbing stairs (improvised code just to display the 'moving up' control input. Don't use it for your project)
            if (canClimb && inputMap.GoUp())
            {
                isClimbing = true;
            }

            if (isClimbing)
            {
                _velocity.y = 0f;;
            }

            if (isClimbing && inputMap.GoUp())
            {
                _animator.Play(Animator.StringToHash("Climb"));
                _velocity.y = 3f;
            }

            if (isClimbing && inputMap.GoDown())
            {
                _animator.Play(Animator.StringToHash("Climb"));
                _velocity.y = -3f;
            }

            if (inputMap.JumpNow())
            {
                isClimbing = false;
            }  //End of climbing hack code

            // apply horizontal speed smoothing it. dont really do this with Lerp. Use SmoothDamp or something that provides more control
            var smoothedMovementFactor = _controller.isGrounded ? groundDamping : inAirDamping; // how fast do we change direction?
            _velocity.x = Mathf.Lerp(_velocity.x, normalizedHorizontalSpeed * runSpeed, Time.deltaTime * smoothedMovementFactor);

            // apply gravity before moving (only if not climbing
            if (!isClimbing)
                _velocity.y += gravity * Time.deltaTime;

            // if holding down bump up our movement amount and turn off one way platform detection for a frame.
            // this lets uf jump down through one way platforms
            if (_controller.isGrounded && inputMap.GoDown())
            {
                _velocity.y *= 3f;
                _controller.ignoreOneWayPlatformsThisFrame = true;
            }

            _controller.move(_velocity * Time.deltaTime);

            // grab our current _velocity to use as a base for all calculations
            _velocity = _controller.velocity;
        }
	}

}
