using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    private int playerScore = 0;

    public GameObject playerText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ball")) 
        {
            GameObject.Find("Ball").transform.position = new Vector2(0, 0);

            // GameObject.Find("Ball").GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-2,2), Random.Range(-2, 2));
            //if()

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
