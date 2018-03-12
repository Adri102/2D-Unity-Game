using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject bloodParticle;
    public int speed;
    public int minRandom;
    public int maxRandom;
    public int health = 0;
    public int maxHealth = 100;
    int random;
    int scoreValue=10;

    public void Start()
    {

        health = maxHealth;
    }
    // Update is called once per frame
    void Update ()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        random = Random.Range(minRandom, maxRandom);

        if (transform.position.x < -10 || health <= 0)
        {
            if(health <= 0) GameObject.Find("UIText").GetComponent<UIBehaviour>().AddScore(scoreValue);
            Reset();
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        GameObject blood = Instantiate(bloodParticle, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.Euler(Vector3.zero));
        Destroy(blood, 1);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Bullet")
        {
            TakeDamage(20);
        }
    }

    public void Reset()
    {
        health = maxHealth;
        transform.position = new Vector3(random, transform.position.y, transform.position.z);
    }
}