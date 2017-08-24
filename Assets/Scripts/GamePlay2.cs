using UnityEngine;
using UnityEngine.UI;
using System;


public class GamePlay2 : MonoBehaviour {
    void Start()
    {
        GenerateAngkaSoal();
        InvokeRepeating("CountDown", 1, 1);
        Pause(false);
    }
    public int a;
    public int b;
    public Text soal;
    System.Random rand = new System.Random();
    public Text timer;

    public void GenerateAngkaSoal()
    {
        a = rand.Next(1, 10);
        b = rand.Next(1, 10);
        timer.text = "10";
        int randJwb = rand.Next(1,3);
        if (randJwb == 1)
            GenerateSoal(true);
        else
            GenerateSoal(false);
    }
    public bool JawabanBenar;

    public void GenerateSoal(bool jwb) {
        if (jwb) {
            soal.text = Convert.ToString(a) + " x " + Convert.ToString(b) + " = " + Convert.ToString(a * b);
            JawabanBenar = true;
        } else {
            soal.text = Convert.ToString(a) + " x " + Convert.ToString(b) + " = " + Convert.ToString(rand.Next(1, 100));
            JawabanBenar = false;
        }
    }

    public void Jawab(bool jwb) {
        if (jwb == JawabanBenar) {
            Invoke("GenerateAngkaSoal", 0.15F);
            CancelInvoke("CountDown");
            InvokeRepeating("CountDown", 1, 1);
        } else {
            //salah
        }
    }

    public void CountDown()
    {
        timer.text = Convert.ToString(Convert.ToInt32(timer.text) - 1);
        if (timer.text == "0")
        {
            CancelInvoke("CountDown");
        }
    }
    public GameObject pauseWindow;

    public void Pause(bool pause)
    {
        pauseWindow.SetActive(pause);
        Debug.Log(pause);
    }
}
