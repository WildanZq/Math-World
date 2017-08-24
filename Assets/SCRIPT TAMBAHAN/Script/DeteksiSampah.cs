using UnityEngine;
using UnityEngine.UI;

public class DeteksiSampah : MonoBehaviour {
	public string nameTag;
	public AudioClip audioBenar;
	public AudioClip audioSalah;
	private AudioSource MediaPlayerBenar;
	private AudioSource MediaPlayerSalah;
	public Text textScore;

	// Use this for initialization
	private void Start()
	{
		MediaPlayerBenar = gameObject.AddComponent<AudioSource>();
		MediaPlayerBenar.clip = audioBenar;

		MediaPlayerSalah = gameObject.AddComponent<AudioSource>();
		MediaPlayerSalah.clip = audioSalah;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag.Equals(nameTag))
		{
			Data.score += 20;
			textScore.text = Data.score.ToString();
			Destroy(collision.gameObject);
			MediaPlayerBenar.Play();
		}
		else
		{
			Data.score -= 15;
			textScore.text = Data.score.ToString();
			Destroy(collision.gameObject);
			MediaPlayerSalah.Play();
		}
	}
}
