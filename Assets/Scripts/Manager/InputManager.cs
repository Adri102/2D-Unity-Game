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
        if(Input.GetButtonDown("Pause")) { Debug.Log("Pause"); }
    }

    void InputGodMode()
    {

    }
    void InputDirectAccess()
    {

    }
    void InputJump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            TouchJumpDown();
        }
        else if(Input.GetButtonUp("Jump"))
        {
            TouchJumpUp();
        }
    }
    void InputShoot()
    {
        //if(Input.GetButton("Fire1"))
        if(Input.GetKeyDown(KeyCode.Z))
        {
            TouchShoot();
        }
        //else bullets.shooting = false;
    }
    public void TouchJumpDown()
    {
        player.JumpStart();
    }
    public void TouchJumpUp()
    {
        player.JumpStop();
    }
    public void TouchShoot()
    {
        Debug.Log("Shoot");
        bullets.shooting = true;
    }
    void InputRevive()
    {
        if(Input.GetKeyDown(KeyCode.X)) player.RevivePlayer();
    }
}
