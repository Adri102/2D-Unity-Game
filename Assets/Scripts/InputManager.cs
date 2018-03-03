using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public CharacterBehaviour player;


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

    void InputRevive()
    {
        if(Input.GetKeyDown(KeyCode.X)) player.RevivePlayer();
    }
}
