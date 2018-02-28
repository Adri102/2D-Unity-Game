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
    public bool isJumping = false;
    [Header("Physics")]
    public Rigidbody2D rb;
    public CollisionDetector collisions;
    [Header("Speed")]
    public float speed;
    [Header("Forces")]
    public float jumpForce;
    [Header("Graphics")]
    public SpriteRenderer rend;
    
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

        if(isJumping)
        {
            isJumping = false;
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    protected virtual void DefaultUpdate()
    {

    }

    void Jump()
    {
        isJumping = true;
    }

    #region Public
    public void JumpStart() //Decidir como será el salto
    {
        if(!canJump) return;

        if(collisions.isGrounded)
        {
            Jump();
        }
    }
    #endregion
}
