using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public GameObject player;
    public GameObject platform;
    public PointEffector2D pointEffector;

    private void Start()
    {
        platform.GetComponent<PointEffector2D>().enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            platform.GetComponent<PointEffector2D>().enabled = true;
        if (Input.GetKeyUp(KeyCode.Space))
            platform.GetComponent<PointEffector2D>().enabled = false;
    }
}
