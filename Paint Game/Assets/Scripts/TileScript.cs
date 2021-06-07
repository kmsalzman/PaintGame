using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileScript : MonoBehaviour
{
    public Sprite playerOnePaint;
    public Sprite playerTwoPaint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "PlayerOne")
        {
            this.gameObject.GetComponent<Image>().sprite = playerOnePaint;
        }
        else if (collision.name == "PlayerTwo")
        {
            this.gameObject.GetComponent<Image>().sprite = playerTwoPaint;
        }
    }
}
