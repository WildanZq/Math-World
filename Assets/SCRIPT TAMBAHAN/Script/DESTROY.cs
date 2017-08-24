using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DESTROY : MonoBehaviour {

	// Use this for initialization


	private void OnTriggerEnter2D (Collider2D collision)
	{
		Destroy (collision.gameObject);
	}
}