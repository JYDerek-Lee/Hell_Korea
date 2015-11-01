using UnityEngine;
using System.Collections;

public class OnKeyDown : MonoBehaviour {
	public int selectScene;
	/*
	void OnGUI () {
		if (GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height / 2 + 10, 100, 30), "Start"))
			Application.LoadLevel ("Char2");
	}
	*/
	void Strat () {

	}

	public void onKeyDown (int selectScene) {
		switch (selectScene) {
			case 1: Application.LoadLevel ("Char1"); break;
			case 2: Application.LoadLevel ("Char2"); break;
			case 3: Application.LoadLevel ("Char3"); break;
			case 4: Application.LoadLevel ("Char4"); break;
			case 5: Application.LoadLevel ("Char5"); break;
			case 6: Application.LoadLevel ("Char6"); break;
			case 7: Application.LoadLevel ("Char7"); break;
			case 8: Application.LoadLevel ("Char8"); break;
			case 9: Application.LoadLevel ("Res"); break;
		}
	}

}
