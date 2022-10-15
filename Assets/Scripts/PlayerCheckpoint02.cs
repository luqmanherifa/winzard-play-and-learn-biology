using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCheckpoint02 : MonoBehaviour
{
    private CheckpointMaster02 cm2;

    // Start is called before the first frame update
    void Start()
    {
        cm2 = GameObject.FindGameObjectWithTag("CM2").GetComponent<CheckpointMaster02>();
        transform.position = cm2.lastCheckpointPos02;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        */
    }
}
