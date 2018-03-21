using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBehaviour : MonoBehaviour
{
    public CharacterBehaviour character;
    public Text Text;
    public Text finalText;
    public int score;
    public float totalScore;
    public float maxScore;
    public float disctance;
    public float distanceMultiplicator;

    void Start ()
    {
		
	}
	
	void Update ()
    {
        Text.text = "Score: " + score + "  Distance: " + (int)disctance;

        if(character.state == CharacterBehaviour.State.Dead)
        {
            if(score <= 0) totalScore = (int)disctance;
            else totalScore = (score * (int)disctance);
            if(totalScore > maxScore) maxScore = totalScore; 
            finalText.text = "                            MaxScore: " + maxScore + "\n\nScore: " + score + "\nDistance: " + (int)disctance + "\nTotal Score: " + totalScore;
        }
        

        disctance += Time.deltaTime * distanceMultiplicator;
    }

    public void AddScore(int ScoreToAdd)
    {
        score += ScoreToAdd;
    }

    public void Reset()
    {
        score = 0;
        disctance = 0;
    }
}
