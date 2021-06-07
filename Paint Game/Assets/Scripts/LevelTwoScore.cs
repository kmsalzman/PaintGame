using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTwoScore : MonoBehaviour
{
    public GameObject player;
    PlayerController controllerScript;
    // Start is called before the first frame update
    void Start()
    {
        controllerScript = player.GetComponent<PlayerController>();
        controllerScript.currentPostion = new Vector3(-17f, -33f, 90f);
        player.transform.position = controllerScript.currentPostion;
        controllerScript.tileNum = 16;
        controllerScript.paintedNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
