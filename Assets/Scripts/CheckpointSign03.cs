using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSign03 : MonoBehaviour
{
    private CheckpointMaster03 cm3;
    public Sprite checkpointChanger;
    private SpriteRenderer renderSprite;

    void Start()
    {
        cm3 = GameObject.FindGameObjectWithTag("CM3").GetComponent<CheckpointMaster03>();
        renderSprite = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            cm3.lastCheckpointPos03 = transform.position;
            renderSprite.sprite = checkpointChanger;
        }
    }
}
