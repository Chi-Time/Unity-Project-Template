public delegate void MenuStateChanged (MenuStates state);

public static class MenuEventManager
{
	public static MenuStateChanged OnMenuStateChanged;
	
	public static void ChangeMenuState (MenuStates state)
	{
		if (OnMenuStateChanged != null)
			OnMenuStateChanged (state);
	}
}
