using UnityEngine;

public class SettingsScreenController : MonoBehaviour
{
    public void ChangeMusicVolume (float volume)
    {

    }

    public void ChangeSFXVolume (float volume)
    {

    }

    public void IncreaseAALevel ()
    {
        var level = QualitySettings.antiAliasing;

        if (level <= 6)
            QualitySettings.antiAliasing++;
    }

    public void DecreaseAALevel ()
    {
        var level = QualitySettings.antiAliasing;

        if (level >= 4)
            QualitySettings.antiAliasing--;
    }

    public void IncreaseQualityLevel ()
    {
        QualitySettings.IncreaseLevel ();
    }

    public void DecreaseQualityLevel ()
    {
        QualitySettings.DecreaseLevel ();
    }

    public void Back ()
    {
        MenuEventManager.ChangeMenuState (MenuStates.MainMenu);
    } 
}
