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
    public GameObject levelScript;
    LevelOneScore leveloneScript;


    // Start is called before the first frame update
    void Start()
    {
        leveloneScript = levelScript.GetComponent <LevelOneScore>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.name == "PlayerOne")
        {
            if (Input.GetKeyDown("d"))
            {
                previousPosition = transform.position;
                transform.Translate(Vector3.right * speed, Space.World);
            }
            else if (Input.GetKeyDown("a"))
            {
                previousPosition = transform.position;
                transform.Translate(Vector3.left * speed, Space.World);
            }
            else if (Input.GetKeyDown("w"))
            {
                previousPosition = transform.position;
                transform.Translate(Vector3.up * speed, Space.World);
            }
            else if (Input.GetKeyDown("s"))
            {
                previousPosition = transform.position;
                transform.Translate(Vector3.down * speed, Space.World);
            }
            
        }    
        else if (this.name == "PlayerTwo")
        {
            if (Input.GetKeyDown("right"))
            {
                previousPosition = transform.position;
                transform.Translate(Vector3.right * speed, Space.World);
            }
            else if (Input.GetKeyDown("left"))
            {
                previousPosition = transform.position;
                transform.Translate(Vector3.left * speed, Space.World);
            }
            else if (Input.GetKeyDown("up"))
            {
                previousPosition = transform.position;
                transform.Translate(Vector3.up * speed, Space.World);
            }
            else if (Input.GetKeyDown("down"))
            {
                previousPosition = transform.position;
                transform.Translate(Vector3.down * speed, Space.World);
            }
        }

        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
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
            leveloneScript.victory(leveloneScript.paintedNum, leveloneScript.goalNum);
        }
        else
        {
            Debug.Log("You can't step there!");
            transform.position = previousPosition;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "End")
        {
            collision.tag = "Taken";
            leveloneScript.goalNum = 1;
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
