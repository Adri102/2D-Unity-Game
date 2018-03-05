using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBehaviour : MonoBehaviour
{
    public Text Text;
    public int score;
    public float disctance;
    public float distanceMultiplicator;

    void Start ()
    {
		
	}
	
	void Update ()
    {
        Text.text = "Score: " + score + "  Distance: " + (int)disctance;

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
