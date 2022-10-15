using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading03 : MonoBehaviour
{
    public Image winzard_loading_fill;

    private void Start()
    {
        StartCoroutine(Stage03Loader());
    }
    IEnumerator Stage03Loader()
    {
        AsyncOperation loading = SceneManager.LoadSceneAsync("PlayStage03");

        while (!loading.isDone)
        {
            winzard_loading_fill.fillAmount = loading.progress/0.9f;
            print(loading.progress);
            yield return null;
        }
    }
}