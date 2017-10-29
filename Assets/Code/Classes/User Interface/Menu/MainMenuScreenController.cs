using UnityEngine;

public class MainMenuScreenController : MonoBehaviour
{
    public void LevelSelect ()
    {
        MenuEventManager.ChangeMenuState (MenuStates.LevelSelect);
    }

    public void Settings ()
    {
        MenuEventManager.ChangeMenuState (MenuStates.Settings);
    }

    public void Credits ()
    {
        MenuEventManager.ChangeMenuState (MenuStates.Credits);
    }

    public void Exit ()
    {
        Application.Quit ();
    } 
}
