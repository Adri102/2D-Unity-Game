
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CollisionDetector))]
public class CharacterBehaviour : MonoBehaviour
{
    public enum State { Default, Dead, GodMode }
    public State state;
    [Header("State")]
    public bool canMove = true;
    public bool canJump = true;
    public bool jump = false;
    private bool isJumping = false;
    private bool releaseJump = false;
    [Header("Physics")]
    public Rigidbody2D rb;
    public CollisionDetector collisions;
    [Header("Speed")]
    public float speed;
    [Header("Forces")]
    public float jumpForce;
    public float jumpReleaseForce;
    [Header("Graphics")]
    public SpriteRenderer rend;

    private float jumpReleaseTime = 0.25f;
    private float timeCounter = 0;
    
    void Start ()
    {
        collisions = GetComponent<CollisionDetector>();
        rb = GetComponent<Rigidbody2D>();
        rend = GetComponentInChildren<SpriteRenderer>();
    }
	
	void Update ()
    {
        switch(state)
        {
            case State.Default:
                DefaultUpdate();
                break;
            case State.Dead:
                DeadUpdate();
                break;
            case State.GodMode:
                break;
            default:
                break;
        }
    }

    private void FixedUpdate()
    {
        collisions.MyFixedUpdate();

        if(collisions.isGrounded)
        {
            isJumping = false;
        }

        if(jump)
        {
            jump = false;
            isJumping = true;
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            Debug.Log("Jump");
        }
        if(isJumping)
        {
            timeCounter += Time.deltaTime;
            if(releaseJump && timeCounter < jumpReleaseTime)
            {
                isJumping = false;
                rb.AddForce(Vector2.up * jumpReleaseForce, ForceMode2D.Impulse);
                Debug.Log("Release Jump");
            }
        }
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    protected virtual void DefaultUpdate()
    {
    }
    protected virtual void DeadUpdate()
    {
        gameObject.SetActive(false);
    }

    #region Public
    public void JumpStart() //Decidir como será el salto
    {
        if(!canJump) return;

        if(collisions.isGrounded)
        {
            timeCounter = 0;
            releaseJump = false;
            isJumping = false;
            jump = true;
        }
    }
    public void JumpStop()
    {
        releaseJump = true;
    }
    #endregion

    public void KillPlayer()
    {
        state = State.Dead;
    }

    public void RevivePlayer()
    {
        state = State.Default;
        gameObject.SetActive(true);
    }
}
