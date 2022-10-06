using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    bool vertical;
    public float speed = 0f;
   
    Rigidbody2D rb;

    float timer;
    public int changeTime;
    int direction;


   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        timer  = changeTime;

    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (vertical)
        {
            Vector2 position = rb.position;


            position.y = position.y + direction * speed * Time.deltaTime;
            rb.MovePosition(position);
        }

        
            


        







    }

}
