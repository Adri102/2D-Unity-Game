using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundsBehaviour : MonoBehaviour
{
	public Material _Ground;
	public float _Speed;

	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		_Ground.mainTextureOffset += new Vector2(_Speed * Time.deltaTime, 0);
		if(_Ground.mainTextureOffset.x >= 18.0f)
			_Ground.mainTextureOffset = new Vector2(0, 0);
	}
}
