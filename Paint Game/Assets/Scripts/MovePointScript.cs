using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePointScript : MonoBehaviour
{
    public float speed = 17.5f;
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

    }

    // Update is called once per frame
    void Update()
    {
        if (this.name == "MovePointOne")
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
        else if (this.name == "MovePointTwo")
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

        }
        else if (collision.tag == "Start")
        {

        }
        else if (collision.tag == "Button")
        {
            
        }
        else if (collision.tag == "End")
        {
            
        }
        else
        {
            Debug.Log("You can't step there!");
            transform.position = previousPosition;
        }
    }
}
