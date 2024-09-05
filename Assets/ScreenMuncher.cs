using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenMuncher : MonoBehaviour
{
    //https://www.youtube.com/watch?v=tHPsIFS_8BY
    //Video used for coding

    public Rigidbody2D rb;
    public int currentcount = 0;

    void go()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb.AddForce(new Vector2(100, 15));
        }
        else
        {
            rb.AddForce(new Vector2(100, 15));
        }
    }
    void Start()
    {
        Invoke("go", 2);
    }

    void Update()
    {
        if (rb.velocity.x == 0)
        {
            rb.velocity = new Vector2(Random.Range(10, 20), rb.velocity.y);
        }
        else if (rb.velocity.y == 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, Random.Range(10, 30));
        }
    }
}