using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public List<GameObject> bullets;
    public Transform playerTransform;
    public CharacterBehaviour player;
    public float counter = 0;
    public int bulletCounter = 0;
    public bool shooting = false;
    public AudioSource soundFXShot;
    public AudioSource soundFXPowered;
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
            
            // busca la primera bala desactivada, la posiciona y la activa
            for(int i = 0; i < bullets.Count; i++)
            {
                if(player.drunk)
                {
                    if(!bullets[i].gameObject.activeSelf)
                    {
                        bullets[i].transform.position = playerTransform.position + new Vector3(0, bulletCounter*0.5f + 0.5f, 0);
                        bullets[i].gameObject.SetActive(true);
                        bulletCounter++;
                        soundFXPowered.Play();
                        if (bulletCounter >= 3)
                        {
                            counter = 0;
                            bulletCounter = 0;
                            shooting = false;
                            break;
                        }
                        
                    }
                }
                else
                {
                    if(!bullets[i].gameObject.activeSelf)
                    {
                        bullets[i].transform.position = playerTransform.position + new Vector3(0, 0.5f, 0);
                        bullets[i].gameObject.SetActive(true);
                        soundFXShot.Play();
                        bulletCounter = 0;
                        counter = 0;
                        shooting = false;
                        break;
                    }
                }
            }
        }		
	}
    public void Reset()
    {
        counter = 0;
        shooting = false;
        for(int i = 0; i < bullets.Count; ++i)
            bullets[i].SetActive(false);
    }
}
