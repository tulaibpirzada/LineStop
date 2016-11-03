using UnityEngine;
using System.Collections;

public class GameStartScreenController : Singleton<GameStartScreenController> 
{
	GameStartScreenReferences gameStartScreenRef;
	
	public void ShowGameStartScreen(GameStartScreenReferences gameStartScreenReferences)
	{
		GameController.Instance.IsUIOpen = true;
		gameStartScreenRef = gameStartScreenReferences;
		gameStartScreenRef.gameObject.SetActive (true);
	}

	public void HideGameStartScreen()
	{
		GameController.Instance.IsUIOpen = false;
		gameStartScreenRef.gameObject.SetActive (false);
	}
}
