using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeLevel02 : MonoBehaviour
{
	//[SerializeField] private string sceneName;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.tag == "Player")
		{
			//SceneManager.LoadScene(sceneName);
			SceneManager.LoadScene(9);
		}
	}

	public void BackStageScene()
	{
		SceneManager.LoadScene(1);
	}

}