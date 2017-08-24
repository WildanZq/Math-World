using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetLastLevel : MonoBehaviour {
	[SerializeField]
	private GameObject[] btnLevel;
	public Sprite lockImage;

	private void Start() {
		for (int i = 0; i < btnLevel.Length; i++) {
			if (PlayerPrefs.GetInt ("lastLevel") >= (i + 1)) {
				btnLevel [i].GetComponent<Button> ().enabled = true;
			} else {
				btnLevel [i].GetComponent<Button> ().enabled = false;
				btnLevel [i].GetComponent<Image>().sprite = lockImage;
			}
		}
	}
}
