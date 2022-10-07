
using UnityEngine;


public class Movement : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    Rigidbody2D rb;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        float input1 = Input.GetAxis("Horizontal");
        

        transform.Translate(input1 * speed * Time.deltaTime,0, 0);
        
    }

    int Jump(int t)
    {
        
          rb.AddForce(transform.up * jumpSpeed);
            
        return t;
    }

   
}
