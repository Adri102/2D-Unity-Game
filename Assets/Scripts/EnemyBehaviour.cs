using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

    public Transform tilemapGround1;
    public int speed;
    public int minRandom;
    public int maxRandom;
    int random;

	// Update is called once per frame
	void Update ()
    {
        tilemapGround1.Translate(Vector2.left * speed * Time.deltaTime);
        random = Random.Range(minRandom, maxRandom);
        if (tilemapGround1.position.x < -8) tilemapGround1.position = new Vector3(random, tilemapGround1.position.y, tilemapGround1.position.z);
    }
}
