using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    private int playerScore = 0;
    public GameObject playerText;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ball")) 
        {
            GameObject.Find("Ball").transform.position = new Vector2(0, 0);

            playerScore++;
            playerText.GetComponent<TextMeshProUGUI>().text = playerScore.ToString();

            GameObject.Find("Ball").GetComponent<LaunchBall>().Launch();
            if(GameObject.Find("Ball").GetComponent<LaunchBall>().speed < 12)
            {
                GameObject.Find("Ball").GetComponent<LaunchBall>().speed += 1;
            }
            
           
        }
        
        

    }
}
