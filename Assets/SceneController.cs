using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	static SceneController Instance;

	void Awake()
	{
		if (Instance != null) 
		{
			GameObject.Destroy (gameObject);
		
		} 

		else
		{
			GameObject.DontDestroyOnLoad (gameObject);
			Instance = this;
		}
	}

	void Update()
	{
		if (Input.GetKeyUp (KeyCode.Alpha1)) {
			SceneManager.LoadScene (0);
		}
		if (Input.GetKeyUp (KeyCode.Alpha2)) {
			SceneManager.LoadScene (1);
		}
		if (Input.GetKeyUp (KeyCode.Alpha3)) {
			SceneManager.LoadScene (2);
		}
		if (Input.GetKeyUp (KeyCode.Alpha4)) {
			SceneManager.LoadScene (3);
		}
		if (Input.GetKeyUp (KeyCode.Alpha5)) {
			SceneManager.LoadScene (4);
		}
	}
}
