using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverScreenEvents : MonoBehaviour 
{
	public void RestartGameButtonTapped()
	{
		SceneManager.LoadScene ("Main");
	}
}
