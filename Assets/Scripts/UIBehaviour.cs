using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBehaviour : MonoBehaviour
{
    public Text _Text;
    public int _Score;
    public float _Disctance;
    public float _DistanceMultiplicator;

    void Start ()
    {
		
	}
	
	void Update ()
    {
        _Text.text = "Score: " + _Score + "  Distance: " + (int)_Disctance;

        _Disctance += Time.deltaTime * _DistanceMultiplicator;
    }

    public void AddScore(int ScoreToAdd)
    {
        _Score += ScoreToAdd;
    }
}
