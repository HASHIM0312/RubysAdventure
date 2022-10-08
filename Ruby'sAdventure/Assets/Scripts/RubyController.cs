using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RubyController : MonoBehaviour
{
    public float speed = 3.0f;

    public int maxHealth = 5;
    public float timeInvincible = 2.0f;
    int currentHealth;
    public int health { get { return currentHealth; } }

    bool isInvincible;
    float invincibleTimer;

    Rigidbody2D rb;
    float horizontal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 10;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
            {
                isInvincible = false;
            }
        }
        
       

    }
    private void FixedUpdate()
    {
        Vector2 position = rb.position;
        position.x += speed * Time.deltaTime * horizontal;
        position.y += speed * Time.deltaTime * vertical;

        rb.MovePosition(position);

        
    }

    public void ChangeHealth(int amount)
    {
        if (amount < 0)
        {
            if (isInvincible)
                return;

            isInvincible = true;
            invincibleTimer = timeInvincible;
        }
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}

