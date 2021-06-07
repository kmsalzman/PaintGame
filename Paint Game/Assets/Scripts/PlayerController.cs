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
    public Image tileImage;
    public Sprite playerOnePaint;
    public Sprite playerTwoPaint;
    LevelOneScore leveloneScript;


    // Start is called before the first frame update
    void Start()
    {
        leveloneScript = levelScript.GetComponent <LevelOneScore>();
        playerOnePaint = Resources.Load<Sprite>("Blue Paint");
        playerTwoPaint = Resources.Load<Sprite>("Pink Paint");
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
        if (collision.tag == "Ground" || collision.tag == "Start")
        {
            collision.tag = "Painted Ground";
            if (this.gameObject.tag == "PlayerOne")
            {
                collision.GetComponent<Image>().sprite = playerOnePaint;
                Debug.Log(tileImage);
            }
            else if (this.gameObject.tag == "PlayerTwo")
            {
                collision.GetComponent<Image>().sprite = playerTwoPaint;
                Debug.Log(tileImage);
            }
            
            leveloneScript.paintedNum++;
            Debug.Log("You painted the ground! Painted " + leveloneScript.paintedNum + " tiles!");
        }
        else if (collision.tag == "Button")
        {
            leveloneScript.lockedDoor.tag = "Ground";
            leveloneScript.lockedDoor2.tag = "Ground";
            leveloneScript.paintedNum++;
        }
        else if (collision.tag == "End")
        {
            collision.tag = "Boundary";
            leveloneScript.goalNum++;
            leveloneScript.victory(leveloneScript.paintedNum, leveloneScript.goalNum);
        }
        else
        {
            Debug.Log("You can't step there!");
            transform.position = previousPosition;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Button")
        {
            leveloneScript.lockedDoor.tag = "Locked";
            leveloneScript.lockedDoor2.tag = "Locked";
        }
    }
}
