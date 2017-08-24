using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class AngkaJawaban : MonoBehaviour {
	void Start() {
		GenerateSoal();
		InvokeRepeating("CountDown", 1, 1);
		Pause(false);
	}
	public string output;
	public Text jawaban;

	public void UpdateJawaban(string input) {
		if (input == "del") {
			if (jawaban.text != "") output = output.Remove(output.Length - 1);
			else output = "";
		} else if (input == "clear") output = "";
		else {
			if (jawaban.text == "") output = input;
			else output = Convert.ToString((Convert.ToInt32(jawaban.text)*10) + Convert.ToInt32(input));
		}
		jawaban.text = output;
		CekJawaban(Convert.ToInt32(output));
	}
	public int a;
	public int b;
	public Text soal;
	System.Random rand = new System.Random();
	public Text timer;

	public void GenerateSoal() {
		a = rand.Next(1, 10);
		b = rand.Next(1, 10);
		soal.text = Convert.ToString(a) + " x " + Convert.ToString(b) + " ?";
		jawaban.text = "";
		timer.text = "10";
	}

	public void CekJawaban(int jwb) {
		if (jwb == a*b) {
			Invoke("GenerateSoal", 0.15F);
			timer.text = "5";
			CancelInvoke("CountDown");
			InvokeRepeating("CountDown", 1, 1);
		}
	}

	public void CountDown() {
		timer.text = Convert.ToString(Convert.ToInt32(timer.text) - 1);
		if (timer.text == "0") {
			CancelInvoke("CountDown");
		}
	}
	public GameObject pauseWindow;

	public void Pause(bool pause) {
		pauseWindow.SetActive(pause);
		Debug.Log(pause);
	}
}
