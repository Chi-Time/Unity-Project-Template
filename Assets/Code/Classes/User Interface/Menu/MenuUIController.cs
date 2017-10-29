using UnityEngine;

public class MenuUIController : MonoBehaviour
{
    private MainMenuScreenController _MenuScreen = null;
    private LevelSelectScreenController _LevelSelectScreen = null;
    private SettingsScreenController _SettingsScreen = null;
    private CreditsScreenController _CreditsScreen = null;

    private void Awake ()
    {
        AssignReferences ();
        MenuEventManager.OnMenuStateChanged += MenuStateChanged;
    }

    private void AssignReferences ()
    {
        _MenuScreen = FindObjectOfType<MainMenuScreenController> ();
        _LevelSelectScreen = FindObjectOfType<LevelSelectScreenController> ();
        _SettingsScreen = FindObjectOfType<SettingsScreenController> ();
        _CreditsScreen = FindObjectOfType<CreditsScreenController> ();
    }

    private void Start ()
    {
        MenuEventManager.ChangeMenuState (MenuStates.MainMenu);
    } 

    private void MenuStateChanged (MenuStates state)
    {
        switch (state)
        {
            case MenuStates.MainMenu:
                SwitchScreen (_MenuScreen.gameObject);
                break;
            case MenuStates.LevelSelect:
                SwitchScreen (_LevelSelectScreen.gameObject);
                break;
            case MenuStates.Settings:
                SwitchScreen (_SettingsScreen.gameObject);
                break;
            case MenuStates.Credits:
                SwitchScreen (_CreditsScreen.gameObject);
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
        MenuEventManager.OnMenuStateChanged -= MenuStateChanged;
    }
}
