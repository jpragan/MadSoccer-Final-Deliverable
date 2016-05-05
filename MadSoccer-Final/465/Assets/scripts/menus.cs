using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class menus : MonoBehaviour
{
	public Canvas controlMenu;
	public Canvas quitMenu;
	public Canvas ControlMenu;
	public Button startText;
	public Button exitText;
	public Button viewControls;


	// Use this for initialization
	void Start () 
	{
		controlMenu = controlMenu.GetComponent<Canvas> ();
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		viewControls = viewControls.GetComponent<Button> ();
		quitMenu.enabled = false;
		controlMenu.enabled = false;
	}

	public void ExitPress()
	{
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;

	}

	public void NoPress()
	{
		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
	}

	public void vieControlsPress()
	{
		controlMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;

	}

	public void gotIt()
	{
		controlMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
	}

	public void StartLevel()
	{
		Application.LoadLevel(1);

	}

	public void ExitGame()
	{
		Application.Quit ();
	}


}
