using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    private GameObject scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (tag == "SmallStarTag")
        {
            this.score += 50;
            this.scoreText.GetComponent<Text>().text = "Score:" + this.score;
        }
        else if (tag == "LargeStarTag")
        {
            this.score += 500;
            this.scoreText.GetComponent<Text>().text = "Score:" + this.score;
        }
        else if (tag == "SmallCloudTag")
        {
            this.score += 150;
            this.scoreText.GetComponent<Text>().text = "Score:" + this.score;
        }
        else if (tag == "LargeCloudTag")
        {
            this.score += 200;
            this.scoreText.GetComponent<Text>().text = "Score:" + this.score;
        }


    }

}
