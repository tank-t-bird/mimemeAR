using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTimerExchange : MonoBehaviour {

	public float sceneDurationSec;
	public int sceneCount;
	float timeSinceLastSceneSwitch = 0f;

	int sceneIdx;

	static SceneTimerExchange Instance;

	void Awake(){
		if(Instance != null){
			GameObject.Destroy (gameObject);
		}else{
			GameObject.DontDestroyOnLoad (gameObject);
			Instance = this;
		}
	}

	void FixedUpdate(){
		timeSinceLastSceneSwitch += Time.deltaTime;
		if (timeSinceLastSceneSwitch >= sceneDurationSec) {
			timeSinceLastSceneSwitch -= sceneDurationSec;
			triggerNextScene();
		}
	}

	void triggerNextScene(){
		sceneIdx = (sceneIdx + 1) % sceneCount; 
		Debug.Log("Switch Scene: "+ sceneIdx);
		SceneManager.LoadScene(sceneIdx);
		// Debug.Log("Next Scene Switch Idx: " + sceneIdx + " because of scene count: " + SceneManager.sceneCount);

	}
}