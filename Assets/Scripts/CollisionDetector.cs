using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CollisionDetector : MonoBehaviour {

    [Header("Ground")]
    [Header("State")]
    public bool isGrounded;
    public bool wasGroundedLastFrame;
    public bool justGrounded;
    public bool justNotGrounded;
    public bool isFalling;

    [Header("Filter")]
    public ContactFilter2D filterGround;
    public int maxCollidersGround = 1;
    public bool checkGround = true;

    [Header("Box Properties")]
    public Vector2 groundBoxPos;
    public Vector2 groundBoxSize;

    [Header("Wall")]
    [Header("State")]
    public bool isTouchingWall;
    public bool wasTouchingWallLastFrame;
    public bool justTouchedWall;
    public bool justNotTouchedWall;
    

    [Header("Filter")]
    public ContactFilter2D filterWall;
    public int maxCollidersWall = 1;
    public bool checkWall = true;

    [Header("Box Properties")]
    public Vector2 wallBoxPos;
    public Vector2 wallBoxSize;

    public void MyFixedUpdate()
    {
        ResetState();
        GroundDetection();
        WallDetection();
    }

    void ResetState()
    {
        wasGroundedLastFrame = isGrounded;
        isFalling = !isGrounded;
        isGrounded = false;
        justGrounded = false;
        justNotGrounded = false;

        wasTouchingWallLastFrame = isTouchingWall;
        isTouchingWall = false;
        justTouchedWall = false;
        justNotTouchedWall = false;
    }

    void GroundDetection()
    {
        if(!checkGround) return;

        Vector3 pos = this.transform.position + (Vector3)groundBoxPos;
        Collider2D[] results = new Collider2D[maxCollidersGround];

        int numColliders = Physics2D.OverlapBox(pos, groundBoxSize, 0, filterGround, results);

        if(numColliders > 0 )
        {
            isGrounded = true;
        }

        if(!wasGroundedLastFrame && isGrounded) justGrounded = true;
        if(wasGroundedLastFrame && !isGrounded) justNotGrounded = true;
    }

    void WallDetection()
    {
        if (!checkWall) return;

        Vector3 pos = this.transform.position + (Vector3)wallBoxPos;
        Collider2D[] results = new Collider2D[maxCollidersWall];

        int numColliders = Physics2D.OverlapBox(pos, wallBoxSize, 0, filterWall, results);

        if (numColliders > 0)
        {
            isTouchingWall = true;
        }

        if (!wasTouchingWallLastFrame && isTouchingWall) justTouchedWall = true;
        if (wasTouchingWallLastFrame && !isTouchingWall) justNotTouchedWall = true;
    }


    public void Flip()
    {
       wallBoxPos.x *= -1;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Vector3 posGround = this.transform.position + (Vector3)groundBoxPos;
        Gizmos.DrawWireCube(posGround, groundBoxSize);

        Gizmos.color = Color.blue;
        Vector3 posWall = this.transform.position + (Vector3)wallBoxPos;
        Gizmos.DrawWireCube(posWall, wallBoxSize);
    }
}
