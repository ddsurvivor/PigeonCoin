using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    private Vector2 direction;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector2(-1, 0);
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("Flip", 3.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = direction * 5;
    }
    void Flip()
    {
        Vector2 scalor = transform.localScale;
        scalor.x *= -1;
        direction.x *= -1;
        transform.localScale = scalor;
    }
}
