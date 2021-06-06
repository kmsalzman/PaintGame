using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public int tileNum;
    public int paintedNum;
    public float score;
    public Vector3 currentPostion;
    private Vector3 previousPosition;

    // Start is called before the first frame update
    void Start()
    {

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
        else
        {
            Debug.Log("You can't step there!");
            transform.position = previousPosition;
        }
    }
}
