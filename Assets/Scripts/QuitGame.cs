using UnityEngine;

public class QuitGame : MonoBehaviour
{
	public void EndGame()
	{
		GameData.SaveGame(0);
		Application.Quit();
	}
}
