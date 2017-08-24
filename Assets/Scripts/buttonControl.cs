using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonControl : MonoBehaviour {

	public void loadScene(string scene){
		SceneManager.LoadScene (scene);
	}
}
