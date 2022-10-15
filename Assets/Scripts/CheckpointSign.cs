using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSign : MonoBehaviour
{
    private CheckpointMaster cm;
    public Sprite checkpointChanger;
    private SpriteRenderer renderSprite;

    void Start()
    {
        cm = GameObject.FindGameObjectWithTag("CM").GetComponent<CheckpointMaster>();
        renderSprite = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            cm.lastCheckpointPos = transform.position;
            renderSprite.sprite = checkpointChanger;
        }
    }
}
