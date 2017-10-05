using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour {

	private void OnGUI()
	{
		if (GUI.Button (new Rect (15, 15, 200, 110), "Load Level"))
			SceneManager.LoadScene (2);
	}
}
