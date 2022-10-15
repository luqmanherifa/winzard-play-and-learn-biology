using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointMaster03 : MonoBehaviour
{
    private static CheckpointMaster03 instance3;
    public Vector2 lastCheckpointPos03;

    void Awake()
    {
        if (instance3 == null)
        {
            instance3 = this;
            DontDestroyOnLoad(instance3);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}