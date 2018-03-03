using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour {
    public List<GameObject> bullets;
    public Transform player;
    public float counter = 0;
    public bool shooting = false;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // contador de la cadencia de tiro
        counter += Time.deltaTime;
        if (counter > 0.5 && shooting)
        {
            counter = 0;
            // busca la primera bala desactivada, la posiciona y la activa
            for(int i = 0; i < bullets.Count; i++)
            {
                if(!bullets[i].gameObject.active)
                {
                    bullets[i].transform.position = player.position + new Vector3(0, 0.5f, 0);
                    bullets[i].gameObject.SetActive(true);
                    break;
                }
            }
        }
        
		
	}
}
