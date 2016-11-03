using UnityEngine;
using System.Collections;

public class GameOverScreenController : Singleton<GameOverScreenController> 
{
	GameOverScreenReferences gameOverScreenRef;

	public void ShowGameOverScreen(GameOverScreenReferences gameOverScreenReferences)
	{
		GameController.Instance.IsUIOpen = true;
		gameOverScreenRef = gameOverScreenReferences;
		gameOverScreenRef.gameObject.SetActive (true);
	}
}
