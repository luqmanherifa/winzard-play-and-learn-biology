using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSign02 : MonoBehaviour
{
    private CheckpointMaster02 cm2;
    public Sprite checkpointChanger;
    private SpriteRenderer renderSprite;

    void Start()
    {
        cm2 = GameObject.FindGameObjectWithTag("CM2").GetComponent<CheckpointMaster02>();
        renderSprite = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            cm2.lastCheckpointPos02 = transform.position;
            renderSprite.sprite = checkpointChanger;
        }
    }
}