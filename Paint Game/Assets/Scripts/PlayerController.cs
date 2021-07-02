using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float score;
    public Vector3 currentPostion;
    private Vector3 previousPosition;
    public Vector3 startingOne;
    public Vector3 startingTwo;
    public Transform movePoint;
    public GameObject levelScript;
    LevelOneScore leveloneScript;
    


    // Start is called before the first frame update
    void Start()
    {
        leveloneScript = levelScript.GetComponent <LevelOneScore>();
        movePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.transform.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            collision.tag = "Painted Ground";
            leveloneScript.paintedNum++;
            Debug.Log("You painted the ground! Painted " + leveloneScript.paintedNum + " tiles!");
        }
        else if (collision.tag == "Start")
        {
            collision.tag = "Boundary";
            leveloneScript.paintedNum++;
        }
        else if (collision.tag == "Button")
        {
            leveloneScript.lockedDoor.tag = "Ground";
            leveloneScript.lockedDoor2.tag = "Ground";
            leveloneScript.paintedNum++;
        }
        else if (collision.tag == "End")
        {
            collision.tag = "Taken";
            leveloneScript.goalNum++;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if ((collision.tag == "Taken") && (transform.position == movePoint.transform.position))
        {
            collision.tag = "Taken";
            leveloneScript.goalNum = 1;
            leveloneScript.victory(leveloneScript.paintedNum, leveloneScript.goalNum);
        } 
            
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Button")
        {
            leveloneScript.lockedDoor.tag = "Locked";
            leveloneScript.lockedDoor2.tag = "Locked";
        }
        else if (collision.tag == "Taken")
        {
            collision.tag = "End";
            leveloneScript.goalNum--;
        }
    }
}
