using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayLogic : MonoBehaviour
{
    public CharacterBehaviour player;
    public EnemyBehaviour enemy;
    public ObstacleBehaviour obstacle;
    public BulletSpawner bulletSpawner;
    public UIBehaviour uIBehaviour;
    public GameObject deadScreen;
    public GameObject tactilButtons;
    public string name = "BOB";

    public bool gameStoped=false;

	void Start ()
    {
        uIBehaviour = GameObject.Find("UIText").GetComponent<UIBehaviour>();
    }

    void Update()
    {
        if(player.state == CharacterBehaviour.State.Dead && !gameStoped)
            StopGame();

       /* if (gameStoped)
        {
            GameData.gameState.maxScore = uIBehaviour.score;
            //GameData.gameState.allScores.Add(name, uIBehaviour.score);
        }*/
    }

    public void StopGame()
    {
        Time.timeScale = 0.0f;
        tactilButtons.SetActive(false);
        deadScreen.SetActive(true);
        gameStoped = true;
    }

    public void ResetGame()
    {
        player.RevivePlayer();
        enemy.Reset();
        obstacle.Reset();
        bulletSpawner.Reset();
        uIBehaviour.Reset();
        tactilButtons.SetActive(true);
        deadScreen.SetActive(false);
        gameStoped = false;
        Time.timeScale = 1.0f;
    }
}
