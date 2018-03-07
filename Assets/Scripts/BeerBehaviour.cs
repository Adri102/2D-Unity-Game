using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerBehaviour : MonoBehaviour {

    public Transform Sprite;
    public int speed;
    public int minPosXRandom;
    public int maxPosXRandom;
    public int minPosYRandom;
    public int maxPosYRandom;
    int randomPosX;
    int randomPosY;
    public CharacterBehaviour player;

    public void Start()
    {
        Sprite = transform;
    }
    // Update is called once per frame
    void Update()
    {
        Sprite.Translate(Vector2.left * speed * Time.deltaTime);
        if(Sprite.position.x < -12) Reset();
    }
    public void Reset()
    {
        randomPosX = Random.Range(minPosXRandom, maxPosXRandom);
        randomPosY = Random.Range(minPosYRandom, maxPosYRandom);
        Sprite.position = new Vector3(randomPosX, randomPosY, Sprite.position.z);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if((other.tag == "Player"))
        {
            player.GetDrunk();
            Reset();
        }
    }
}
