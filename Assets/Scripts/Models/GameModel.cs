using UnityEngine;
using System.Collections;

public class GameModel : Singleton<GameModel> 
{
	private int score;
	private int lineMovementSpeed;
	private float lineMinPositionX;
	private float lineMaxPositionX;

	public int Score
	{
		get{ return score;}
		set{score = value;}
	}

	public int LineMovementSpeed
	{
		get{ return lineMovementSpeed;}
	}

	public float LineMinPositionX
	{
		get{ return lineMinPositionX;}
	}

	public float LineMaxPositionX
	{
		get{ return lineMaxPositionX;}
	}

	public void SetUpGameVariables()
	{
		score = 0;
		lineMovementSpeed = 5;
		lineMinPositionX = -301.8f;
		lineMaxPositionX = 301.8f;
	}
}
