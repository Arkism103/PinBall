using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    private float visiblePosZ = -6.5f;

    private GameObject gameoverText;
    private GameObject scoreText;
    private int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {

        if (this.transform.position.z < visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.score += 50;
            this.scoreText.GetComponent<Text>().text = "Score:" + this.score;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.score += 500;
            this.scoreText.GetComponent<Text>().text = "Score:" + this.score;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.score += 150;
            this.scoreText.GetComponent<Text>().text = "Score:" + this.score;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 200;
            this.scoreText.GetComponent<Text>().text = "Score:" + this.score;
        }
    }
}