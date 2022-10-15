using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fall : MonoBehaviour
{
	[SerializeField] private string sceneToLoad;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.tag == "Player")
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
