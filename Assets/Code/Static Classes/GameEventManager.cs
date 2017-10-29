public delegate void GameStateChanged (GameStates state);

public static class GameEventManager
{
	public static GameStateChanged OnGameStateChanged;
	
	public static void ChangeGameState (GameStates state)
	{
		if (OnGameStateChanged != null)
			OnGameStateChanged (state);
	}
}
