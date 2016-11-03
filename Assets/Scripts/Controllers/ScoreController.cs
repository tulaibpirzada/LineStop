using UnityEngine;
using System.Collections;

public class ScoreController : Singleton<ScoreController> 
{
	private bool shouldStartGameMechanics;
	GameReferences gameRef;

	public bool IsScreenTapped {
		get;
		set;
	}

	public bool IsValidTap {
		get;
		set;
	}

	public bool ShouldStartOscillatingLine {
		get;
		set;
	}

	public void Init(GameReferences gameReferences)
	{
		gameRef = gameReferences;
		shouldStartGameMechanics = true;
		this.ShouldStartOscillatingLine = true;
		this.IsScreenTapped = false;
		this.IsValidTap = false;
	}

	void Update()
	{
		if (shouldStartGameMechanics) {
			
			if ((Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) || (Input.GetMouseButtonDown (0))) {

				this.IsScreenTapped = true;
				Vector3 worldPoint = Vector3.zero;
				#if UNITY_EDITOR
				worldPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				//for touch device
				#elif (UNITY_ANDROID || UNITY_IPHONE || UNITY_WP8)
				worldPoint = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
				#endif

//				if (gameRef.circle.GetComponent<Collider2D> ().OverlapPoint (worldPoint) && gameRef.movingLine.GetComponent<Collider2D> ().OverlapPoint (worldPoint)) {
//
//
//
//				} else {
//
//
//				}
			}

			if (this.IsScreenTapped  && ((Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) || (Input.GetMouseButtonUp (0)))) {

				if (this.IsValidTap) {
					DoValidTapActions ();
				}
				else {
					DoInvalidTapActions ();
				}
				this.IsScreenTapped = false;
			}
		}
	}

	public void DoValidTapActions()
	{
		GameController.Instance.UpdateScore (1);
		gameRef.gameAudioSource.clip = gameRef.tapSound;
		gameRef.gameAudioSource.Play ();
		gameRef.movingLine.GetComponent<LineMover> ().IncreaseSpeed ();
	}

	public void DoInvalidTapActions()
	{
		gameRef.gameAudioSource.clip = gameRef.wrongTapSound;
		gameRef.gameAudioSource.Play ();
		GameController.Instance.EndGame ();
	}


	public void StopScoring()
	{
		shouldStartGameMechanics = false;
		this.ShouldStartOscillatingLine = false;
	}
}
