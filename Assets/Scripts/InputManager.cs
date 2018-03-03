using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public CharacterBehaviour player;
    public BulletSpawner bullets;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterBehaviour>();
    }

    void Update()
    {
        // Leer para pausar el juego
        InputPause();
        // salto del player
        InputJump();
        InputRevive();
        // disparo del player
        InputShoot();
    }

    void InputPause()
    {
        if (Input.GetButtonDown("Pause")) { Debug.Log("Pause"); }
    }

    void InputJump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump");
            player.JumpStart();
        }
    }

    void InputGodMode()
    {

    }
    void InputDirectAccess()
    {

    }

    void InputShoot()
    {
        if(Input.GetButton("Fire1"))
        {
            Debug.Log("Shooting");
            bullets.shooting = true;
        }
        else bullets.shooting = false;
    }

    void InputRevive()
    {
        if(Input.GetKeyDown(KeyCode.X)) player.RevivePlayer();
    }
}
