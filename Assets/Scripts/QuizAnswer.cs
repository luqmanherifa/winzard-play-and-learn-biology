using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizAnswer : MonoBehaviour
{
    public GameObject jawabBenar, jawabSalah;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void jawaban(bool jawab)
    {
        if (jawab)
        {
            jawabBenar.SetActive(false);
            jawabBenar.SetActive(true);
            int skor = PlayerPrefs.GetInt("NilaiSkor") + 1;
            PlayerPrefs.SetInt("NilaiSkor", skor);
        } else
        {
            jawabSalah.SetActive(false);
            jawabSalah.SetActive(true);
        }
        gameObject.SetActive(false);
        transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
