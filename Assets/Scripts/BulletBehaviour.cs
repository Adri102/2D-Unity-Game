using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    public int speed;
    public EnemyBehaviour enemy;
    public GameObject sparksParticle;
    public AudioSource soundFX;

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
        if ((other.tag != "Player") && (other.tag != "Beer"))
        {
            if (other.tag == "Obstacle")
            {
                GameObject sparks = Instantiate(sparksParticle, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(Vector3.zero));
                Destroy(sparks, 1);
                soundFX.Play();
            }
            gameObject.SetActive(false);
        }
    }
}
