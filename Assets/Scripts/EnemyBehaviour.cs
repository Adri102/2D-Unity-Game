using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public Transform Sprite;
    public int speed;
    public int minRandom;
    public int maxRandom;
    public int health = 0;
    public int maxHealth = 100;
    int random;
    int scoreValue=10;

    public void Start()
    {
        Sprite = transform;
        health = maxHealth;
    }
    // Update is called once per frame
    void Update ()
    {
        Sprite.Translate(Vector2.left * speed * Time.deltaTime);
        random = Random.Range(minRandom, maxRandom);

        if (Sprite.position.x < -8 || health <= 0)
        {
            if(health <= 0) GameObject.Find("UIText").GetComponent<UIBehaviour>().AddScore(scoreValue);
            Reset();
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    public void Reset()
    {
        health = maxHealth;
        Sprite.position = new Vector3(random, Sprite.position.y, Sprite.position.z);
    }
}