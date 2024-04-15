using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    

    // Start is called before the first frame update
    void Start()
    {
        Launch();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void Launch()
    {
        
        //rb.velocity = new Vector2(speed * Random.Range(-2, 2), speed * Random.Range(-2, 2));
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    
}
