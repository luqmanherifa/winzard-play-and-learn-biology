using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUnlock : MonoBehaviour
{
	public void Pass()
	{
		int nexSceneLoad = SceneManager.GetActiveScene().buildIndex;

		if (nexSceneLoad >= PlayerPrefs.GetInt("levelsUnlocked"))
		{
			PlayerPrefs.SetInt("levelsUnlocked", nexSceneLoad + 1);
		}
		SceneManager.LoadScene(1);
	}
}
