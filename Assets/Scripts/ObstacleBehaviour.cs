using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour {

    public Transform Sprite;
    public int speed;
    public int minRandom;
    public int maxRandom;
    int random;

    public void Start()
    {
        Sprite = transform;
    }
    // Update is called once per frame
    void Update()
    {
        Sprite.Translate(Vector2.left * speed * Time.deltaTime);
        random = Random.Range(minRandom, maxRandom);

        if(Sprite.position.x < -8) Reset();
    }
    public void Reset()
    {
        Sprite.position = new Vector3(random, Sprite.position.y, Sprite.position.z);
    }
}
