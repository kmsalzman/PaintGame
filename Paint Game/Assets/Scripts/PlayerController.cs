using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private int tileNum;
    private int paintedNum = 0;
    private float score;
    private Vector3 currentPostion;
    private Vector3 previousPosition;

    // Start is called before the first frame update
    void Start()
    {
        currentPostion = new Vector3(-34.1105f, -16.0905f, 90f);
        transform.position = currentPostion;
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            tileNum = 9;
        }
    }

    // Update is called once per frame
    void Update()
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
        else if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            currentPostion = new Vector3(-34.1105f, -16.0905f, 90f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            collision.tag = "Painted Ground";
            paintedNum++;
            Debug.Log("You painted the ground!");
        }
        else if (collision.tag == "End")
        {
            score = (paintedNum / tileNum) * 100;
            Debug.Log("You won! Your score is: " + score + "%");
            SceneManager.LoadScene("GameOver");
        }
        else if (collision.tag == "Painted Ground")
        {
            Debug.Log("You can't step there!");
            transform.position = previousPosition;
        }
    }
}
