using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public Collider2D collider;
    public Collider2D[] results;
    public ContactFilter2D contactFilter;
    public int numCollider;
    public Vector2 boxSize;


    void FixedUpdate ()
    {
        //numCollider = Physics2D.OverlapCollider(collider, contactFilter, results);
        numCollider = Physics2D.OverlapBox(this.transform.position, boxSize, 0, contactFilter, results);


    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireCube(this.transform.position, boxSize);
    }
}
