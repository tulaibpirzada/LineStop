using UnityEngine;
using System.Collections;

public class GameStartScreenEvents : MonoBehaviour 
{
	public void StartGameButtonTapped()
	{
		GameController.Instance.StartGame ();
	}
}
