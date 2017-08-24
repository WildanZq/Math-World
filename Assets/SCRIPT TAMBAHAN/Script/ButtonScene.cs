using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScene : MonoBehaviour
{
	public GameObject ImageAboutUs;
	public GameObject MainButton;
	public void changeToScene(int ChangeScene)
	{
		SceneManager.LoadScene(ChangeScene);
	}
	public void ExitGame()
	{
		Application.Quit();
	}
	public void AboutUs()
	{
		ImageAboutUs.SetActive(true);
		MainButton.SetActive(false);
	}
	public void back()
	{
		ImageAboutUs.SetActive(false);
		MainButton.SetActive(true);
	}
}
