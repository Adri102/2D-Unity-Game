using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public CharacterBehaviour player;
    public BulletSpawner bullets;

    public float savedJumpForce;
    public bool startJump=false;

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

        if(startJump)
        {
            Debug.Log("JUMP");
            savedJumpForce += Time.deltaTime * 20;
            if(player.jumpForce <= savedJumpForce)
            {
                player.JumpStart(savedJumpForce);
                startJump = false;
            }
        }

        Debug.Log(savedJumpForce);
    }

    void InputPause()
    {
        if(Input.GetButtonDown("Pause")) { Debug.Log("Pause"); }
    }

    void InputJump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump");
            //player.JumpStart(player.jumpForce);
            savedJumpForce = player.jumpForce * 0.65f;
            startJump = true;
        }
        else if(Input.GetButtonUp("Jump") && startJump)
        {
            Debug.Log("JUMP");
            player.JumpStart(savedJumpForce);
            startJump = false;
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
        //if(Input.GetButton("Fire1"))
        if(Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Shooting");
            bullets.shooting = true;
        }
        //else bullets.shooting = false;
    }

    void InputRevive()
    {
        if(Input.GetKeyDown(KeyCode.X)) player.RevivePlayer();
    }

    /*public void TouchJumpDown()
    {
        Debug.Log("JUMP");
        player.JumpStart( );
    }*/
    public void TouchJumpDown()
    {
        savedJumpForce = player.jumpForce * 0.65f;
        startJump = true;
    }
    public void TouchJumpUp()
    {
        if(startJump)
        {
            Debug.Log("JUMP");
            player.JumpStart(savedJumpForce);
            startJump = false;
        }
    }
    public void TouchShoot()
    {
        Debug.Log("Shoot");
        bullets.shooting = true;
    }

}
