using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SetSceneTimer : MonoBehaviour {
	
	public string levelToLoad;
	public Text textScore;
	private float timer = 35f;
	private Text timerSeconds;

	// Use this for initialization
	void Start () 
	{
		timerSeconds = GetComponent<Text>();
		Data.score = 0;
	}
	
	// Update is called once per frame

	void Update () 
	{
		timer -= Time.deltaTime;
		timerSeconds.text = timer.ToString ("f2");
		if (timer <= 0 
			&& Data.score <= 0)  
		{
			SceneManager.LoadScene("Gameover");
	}
		else if (timer <= 0 
			&&  (Data.score >= 25 && Data.score <= 100 ))
		{
			SceneManager.LoadScene("WIN");
		}
		else if (timer <= 0 
			&& (Data.score >= 101 && Data.score <= 150))
		{
			SceneManager.LoadScene("WIN2");
		}
		else if (timer <= 0 
			&& (Data.score >= 151 && Data.score <= 200))
		{
			SceneManager.LoadScene("WIN3");
		}
		else if (timer <= 0 
			&& (Data.score >= 201 && Data.score <= 300))
		{
			SceneManager.LoadScene("WIN4");
		}
		else if (timer <= 0 
			&& Data.score >= 301)
		{
			SceneManager.LoadScene("WIN5");
		}
		//, LoadSceneMode.Single


}
}