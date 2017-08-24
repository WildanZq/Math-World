using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Boomlagoon.JSON;

public class LocalDatabase : MonoBehaviour {
	public static LocalDatabase Instance { get; private set; }

	private void Awake()
	{
		Instance = this;

		if (!PlayerPrefs.HasKey("lastLevel"))
		{
			PlayerPrefs.SetInt("lastLevel", 1);
		}
	}

	public void setLastLevel(int level) {
		int l = PlayerPrefs.GetInt("lastLevel") + 1;
		if (level == l) PlayerPrefs.SetInt("lastLevel", l);
	}
}
