using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading01 : MonoBehaviour
{
    public Image winzard_loading_fill;

    private void Start()
    {
        StartCoroutine(Stage01Loader());
    }
    IEnumerator Stage01Loader()
    {
        AsyncOperation loading = SceneManager.LoadSceneAsync("PlayStage01");

        while (!loading.isDone)
        {
            winzard_loading_fill.fillAmount = loading.progress/0.9f;
            print(loading.progress);
            yield return null;
        }
    }
}