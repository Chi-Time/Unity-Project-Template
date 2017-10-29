using UnityEngine;

public class GameUIController : MonoBehaviour
{
    private GameScreenController _GameScreen = null;
    private PauseScreenController _PauseScreen = null;
    private GameOverScreenController _GameOverScreen = null;

    private void Awake ()
    {
        AssignReferences ();
        GameEventManager.ChangeGameState (GameStates.Game);
    }

    private void AssignReferences ()
    {
        _GameScreen = FindObjectOfType<GameScreenController> ();
        _PauseScreen = FindObjectOfType<PauseScreenController> ();
        _GameOverScreen = FindObjectOfType<GameOverScreenController> ();
    }

    private void Start ()
    {
        GameEventManager.OnGameStateChanged += GameStateChanged;
    }

    private void GameStateChanged (GameStates state)
    {
        switch (state)
        {
            case GameStates.Game:
                SwitchScreen (_GameScreen.gameObject);
                break;
            case GameStates.Pause:
                SwitchScreen (_PauseScreen.gameObject);
                break;
            case GameStates.GameOver:
                SwitchScreen (_GameOverScreen.gameObject);
                break;
        }
    }

    /// <summary>Sets every child screen to off and then activates only the given the screen.</summary>
    /// <param name="screen">The screen to activate.</param>
    private void SwitchScreen (GameObject screen)
    {
        for (int i = 0; i < transform.childCount; i++)
            transform.GetChild (i).gameObject.SetActive (false);

        screen.SetActive (true);
    }

    private void OnDestroy ()
    {
        GameEventManager.OnGameStateChanged -= GameStateChanged;
    }
}
