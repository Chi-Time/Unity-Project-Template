using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectScreenController : MonoBehaviour
{
    public void SelectLevel (string levelName)
    {
        SceneManager.LoadScene (levelName);
    }

    public void Back ()
    {
        MenuEventManager.ChangeMenuState (MenuStates.MainMenu);
    }
}
