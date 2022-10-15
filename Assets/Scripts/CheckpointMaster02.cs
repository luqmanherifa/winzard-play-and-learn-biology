using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointMaster02 : MonoBehaviour
{
    private static CheckpointMaster02 instance2;
    public Vector2 lastCheckpointPos02;

    void Awake()
    {
        if (instance2 == null)
        {
            instance2 = this;
            DontDestroyOnLoad(instance2);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}