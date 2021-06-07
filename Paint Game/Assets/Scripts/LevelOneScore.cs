using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOneScore : MonoBehaviour
{
    public GameObject overlay;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject playerOne;
    public GameObject playerTwo;
    public GameObject lockedDoor;
    public GameObject lockedDoor2;
    public int goalNum;
    public int goalTotal;
    public int paintedNum;
    public float tileNum;
    public float score;
    PlayerController controllerScript;
    Scene currentScene;

    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        controllerScript = playerOne.GetComponent<PlayerController>();
        if (currentScene.name == "Level1")
        {
            controllerScript.startingOne = new Vector3(-34.1105f, -16.0905f, 90f);
            tileNum = 10f;
            goalTotal = 1;
        }
        else if (currentScene.name == "Level2")
        {
            controllerScript.startingOne = new Vector3(-16.7136f, -33.0435f, 90f);
            controllerScript.startingTwo = new Vector3(17f, -33.0435f, 90f);
            tileNum = 16f;
            goalTotal = 2;
        }
        else if (currentScene.name == "Level3")
        {
            controllerScript.startingOne = new Vector3(-16.2f, -32.9f, 90f);
            controllerScript.startingTwo = new Vector3(17f, -33f, 90f);
            tileNum = 9f;
            goalTotal = 2;
        }
        else if (currentScene.name == "Level4")
        {
            controllerScript.startingOne = new Vector3(-51.07925f, -4.266584f, 90f);
            controllerScript.startingTwo = new Vector3(51.5f, -4.5f, 90f);
            tileNum = 24f;
            goalTotal = 2;
        }
        else if (currentScene.name == "Level5")
        {
            controllerScript.startingOne = new Vector3(-8.4637f, -32.9892f, 90f);
            controllerScript.startingTwo = new Vector3(8.2f, -32.8f, 90f);
            tileNum = 14f;
            goalTotal = 2;
        }
        else if (currentScene.name == "Level6")
        {
            controllerScript.startingOne = new Vector3(-51.07925f, 12.5f, 90f);
            controllerScript.startingTwo = new Vector3(51.5f, 12.5f, 90f);
            tileNum = 28f;
            goalTotal = 2;
        }
        
        playerOne.transform.position = controllerScript.startingOne;
        playerTwo.transform.position = controllerScript.startingTwo;
        
        paintedNum = 0;
        overlay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void victory(int paintedTiles, int goal)
    {
        if (goal == goalTotal)
        {
            score = paintedTiles / tileNum * 100f;

            if (score < 33)
            {
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(false);
            }
            else if (score > 33 && score < 66)
            {
                star1.SetActive(true);
                star2.SetActive(false);
                star3.SetActive(false);
            }
            else if (score > 66 && score < 100)
            {
                star1.SetActive(true);
                star2.SetActive(false);
                star3.SetActive(true);
            }
            else
            {
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
            }
            Debug.Log("You won! Your score is: " + score + "% tileNum: " + tileNum + " paintedTiles: " + paintedTiles);
            overlay.SetActive(true);
        }
        else
        {
            Debug.Log("Not Enough Goal " + goal + "Goal total: " + goalTotal);
        }
    }
}
