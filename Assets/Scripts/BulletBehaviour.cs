using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    public int speed;
    // Use this for initialization
    void Start()
    {

    }

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
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy") gameObject.SetActive(false);
    }
}
