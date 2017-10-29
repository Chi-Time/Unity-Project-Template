using UnityEngine;

public class GameController
{
	private void Awake ()
	{
		AssignReferences ();
		
		GameEventManager.OnGameStateChanged += GameStateChanged;
	}
	
	private void AssignReferences ()
	{
		
	}
	
	private void Start ()
	{
		SetDefaults ();
	}
	
	private void SetDefaults ()
	{
		
	}
	
	private void GameStateChanged (GameStates state)
	{
		switch (state)
		{
		    case GameStates.Game:
			
			    break;
		    case GameStates.Pause:
			
			    break;
		    case GameStates.GameOver:
			
			    break;
		}
	}
	
	private void OnDestroy ()
	{
		GameEventManager.OnGameStateChanged -= GameStateChanged;
	}
}
