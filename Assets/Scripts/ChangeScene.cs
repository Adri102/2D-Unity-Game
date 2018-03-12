using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
	LevelLogic levelLogic;

	public void Activated()
	{
		levelLogic = GameObject.Find("Managers").GetComponent<LevelLogic>();
		levelLogic.NexScene();
	}
}