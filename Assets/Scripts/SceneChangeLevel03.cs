using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeLevel03 : MonoBehaviour
{
	//[SerializeField] private string sceneName;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.tag == "Player")
		{
			//SceneManager.LoadScene(sceneName);
			SceneManager.LoadScene(12);
		}
	}

	public void BackMenuScene()
	{
		SceneManager.LoadScene(0);
	}
}