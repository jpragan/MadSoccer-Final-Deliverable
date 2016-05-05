using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public Canvas quitMenu;
	public Button startText;
	public Button exitText;

	void Start () 
	{
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
	}

	public void LoadScene(string name)
	{
		Application.LoadLevel(name);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
