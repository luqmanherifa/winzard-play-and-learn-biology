using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading02 : MonoBehaviour
{
    public Image winzard_loading_fill;

    private void Start()
    {
        StartCoroutine(Stage02Loader());
    }
    IEnumerator Stage02Loader()
    {
        AsyncOperation loading = SceneManager.LoadSceneAsync("PlayStage02");

        while (!loading.isDone)
        {
            winzard_loading_fill.fillAmount = loading.progress / 0.9f;
            print(loading.progress);
            yield return null;
        }
    }
}