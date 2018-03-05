using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveIDScore : MonoBehaviour
{
    public string path = "resources/";
    public string fileName = "ScoreFile.txt";
    void Start ()
    {
		if (!File.Exists(path + fileName))
        {
            FileStream oFileStream = null;
            oFileStream = new FileStream(path + fileName, FileMode.CreateNew);
            oFileStream.Close();
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
