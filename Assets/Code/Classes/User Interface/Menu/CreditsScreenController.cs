using UnityEngine;

public class CreditsScreenController : MonoBehaviour
{
    public void Back ()
    {
        MenuEventManager.ChangeMenuState (MenuStates.MainMenu);
    }
}
