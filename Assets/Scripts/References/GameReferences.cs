using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameReferences : MonoBehaviour 
{
	public Text scoreLabel;
	public Text tapLabel;
	public GameObject movingLine;
	public GameObject circle;
	public AudioClip tapSound;
	public AudioClip wrongTapSound;
	public AudioSource gameAudioSource;
	public GameStartScreenReferences gameStartScreenRef;
	public GameOverScreenReferences gameOverScreenRef;
}
