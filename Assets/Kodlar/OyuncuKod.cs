using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKod : MonoBehaviour
{

    [SerializeField] float hizCarpani;
    Rigidbody2D rb;
    Vector2 hareketVectoru;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        hizCarpani = 5.0f;
    }
    private void FixedUpdate()
    {
        hareketVectoru.x = 0.0f;
        if (Input.GetKey(KeyCode.D))
        {
            hareketVectoru.x = hizCarpani;
        }
        if (Input.GetKey(KeyCode.A))
        {
            hareketVectoru.x = -hizCarpani;
        }
        rb.velocity = hareketVectoru;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
