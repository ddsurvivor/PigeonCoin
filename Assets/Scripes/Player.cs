using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;

    public float jumpForce;
    private bool isGrounded;
    public GameObject checkPos;
    public LayerMask ground;

    public float timeBtwShot;
    public float startTime;
    public GameObject shotPos;
    public GameObject coin;
    public int count;

    public Text text;


    // Start is called before the first frame update
    void Start()
    {
        text.text = "Coins:" + count.ToString();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics2D.OverlapCircle(checkPos.transform.position, 0.3f, ground); 
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        if (timeBtwShot <= 0 && count >0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                GameObject c = Instantiate(coin, shotPos.transform.position, shotPos.transform.rotation);
                c.GetComponent<Rigidbody2D>().AddForce(shotPos.transform.right * 500);
                count--;
                text.text = "Coins:" + count.ToString();
                timeBtwShot = startTime;
            }
        }
        else
        {
            timeBtwShot -= Time.deltaTime;
        }

        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }
}
