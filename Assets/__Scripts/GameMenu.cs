using UnityEngine;
using System.Collections;

public class GameMenu : MonoBehaviour {

	public void OnStartClick() {
		Application.LoadLevel ("IntroScreen");
	}

    public void OnEnemyClick()
    {
        Application.LoadLevel("Enemy");
    }

	public void OnContinueClick() {
		Application.LoadLevel ("Level_One");
	}

    public void OnBackClick()
    {
        Application.LoadLevel("GameStart");
    }

	public void OnExitClick() {
		Application.Quit ();
	}
}
