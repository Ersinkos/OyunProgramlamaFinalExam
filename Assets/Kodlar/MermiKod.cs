using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiKod : MonoBehaviour
{
    Rigidbody2D rb;
    float hizCarpani;
    // Start is called before the first frame update
    void Start()
    {
        hizCarpani = 3.0f;
        rb = GetComponent<Rigidbody2D>();

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "UstSinir")
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "UstSinir")
        {
            rb.velocity = new Vector2(0.0f, hizCarpani);
        }
    }
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localScale += new Vector3(0.0f, hizCarpani, 0.0f) * Time.deltaTime;
    }
}
