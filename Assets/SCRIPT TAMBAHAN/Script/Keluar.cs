using UnityEngine;

public class Keluar : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}