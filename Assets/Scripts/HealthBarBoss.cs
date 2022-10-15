using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBoss : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealthBoss(int healthBoss)
    {
        slider.maxValue = healthBoss;
        slider.value = healthBoss;
    }

    public void SetHealthBoss(int healthBoss)
    {
        slider.value = healthBoss;
    }
}
