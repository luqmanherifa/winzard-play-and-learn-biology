using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCheckpoint03 : MonoBehaviour
{
    private CheckpointMaster03 cm3;

    // Start is called before the first frame update
    void Start()
    {
        cm3 = GameObject.FindGameObjectWithTag("CM3").GetComponent<CheckpointMaster03>();
        transform.position = cm3.lastCheckpointPos03;
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
