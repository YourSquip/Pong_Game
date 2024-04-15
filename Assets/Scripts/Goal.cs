using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update

    bool isPlayer1Goal;
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
            GameObject.Find("Ball").GetComponent<LaunchBall>().Launch();
            GameObject.Find("Ball").GetComponent<LaunchBall>().speed += 1;
        }
    }
}
