using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public int scoreOne = 0;
    public int scoreTwo = 0;
    public int scoreThree = 0;
    public int scoreFour = 0;
    public int scoreFive = 0;
    public int scoreSix = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void setStar(int starNum)
    {
        scoreOne = starNum;
        if (scoreOne == 0)
        {
            star1.SetActive(false);
            star2.SetActive(false);
            star3.SetActive(false);
        }
        else if (scoreOne == 1)
        {
            star1.SetActive(true);
            star2.SetActive(false);
            star3.SetActive(false);
        }
        else if (scoreOne == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(false);
        }
        else if (scoreOne == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
        }
        else if (scoreTwo == 0)
        {
            star1.SetActive(false);
            star2.SetActive(false);
            star3.SetActive(false);
        }
        else if (scoreTwo == 1)
        {
            star1.SetActive(true);
            star2.SetActive(false);
            star3.SetActive(false);
        }
        else if (scoreTwo == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(false);
        }
        else if (scoreTwo == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
        }
        else if (scoreThree == 0)
        {
            star1.SetActive(false);
            star2.SetActive(false);
            star3.SetActive(false);
        }
        else if (scoreThree == 1)
        {
            star1.SetActive(true);
            star2.SetActive(false);
            star3.SetActive(false);
        }
        else if (scoreThree == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(false);
        }
        else if (scoreThree == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
        }
        else if (scoreFour == 0)
        {
            star1.SetActive(false);
            star2.SetActive(false);
            star3.SetActive(false);
        }
        else if (scoreFour == 1)
        {
            star1.SetActive(true);
            star2.SetActive(false);
            star3.SetActive(false);
        }
        else if (scoreFour == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(false);
        }
        else if (scoreFour == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
        }
        else if (scoreFive == 0)
        {
            star1.SetActive(false);
            star2.SetActive(false);
            star3.SetActive(false);
        }
        else if (scoreFive == 1)
        {
            star1.SetActive(true);
            star2.SetActive(false);
            star3.SetActive(false);
        }
        else if (scoreFive == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(false);
        }
        else if (scoreFive == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
        }
        else if (scoreSix == 0)
        {
            star1.SetActive(false);
            star2.SetActive(false);
            star3.SetActive(false);
        }
        else if (scoreSix == 1)
        {
            star1.SetActive(true);
            star2.SetActive(false);
            star3.SetActive(false);
        }
        else if (scoreSix == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(false);
        }
        else if (scoreSix == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
        }
    }
}
