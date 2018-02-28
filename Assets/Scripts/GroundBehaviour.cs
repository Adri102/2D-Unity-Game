using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBehaviour : MonoBehaviour {

    public Transform tilemapGround1;
    public Transform tilemapGround2;
    public int speed;

	// Update is called once per frame
	void Update ()
    {
        tilemapGround1.Translate(Vector2.left * speed * Time.deltaTime);
        tilemapGround2.Translate(Vector2.left * speed * Time.deltaTime);

        if (tilemapGround1.position.x < -63) tilemapGround1.position = new Vector3(63, tilemapGround1.position.y, tilemapGround1.position.z);
        if (tilemapGround2.position.x < -63) tilemapGround2.position = new Vector3(63 + tilemapGround1.position.x, tilemapGround2.position.y, tilemapGround2.position.z);
    }
}
