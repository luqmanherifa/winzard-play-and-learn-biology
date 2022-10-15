using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageMenu : MonoBehaviour
{
    /* public Button[] buttons;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        int levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked", 1);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        for (int i = 0; i < levelsUnlocked; i++)
        {
            buttons[i].interactable = true;
        }
    } */

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }


    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }
}
