using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    public int speed;
    public EnemyBehaviour enemy;

    // Update is called once per frame
    void Update()
    {
        // movimiento de la bala
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        if(transform.position.x > 10)
        {
            transform.position = new Vector3(0, transform.position.y, 0);
            gameObject.SetActive(false);
        }
    }

    // colision con enemigo
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            enemy.TakeDamage(20);
            gameObject.SetActive(false);
        }
    }
}
