using UnityEngine;
using System.Collections;

public class PauseBtn : MonoBehaviour {
    public GameObject pausePopup;
    public void Pause() {
        pausePopup.SetActive(true);
    }
    public void Resume() {
        pausePopup.SetActive(false);
    }
}
