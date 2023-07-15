using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanKod : MonoBehaviour
{
    Rigidbody2D rb;
    public float hizCarpani;
    int yasam;
    Color rastgeleRenk;
    // Start is called before the first frame update
    void Start()
    {

        gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 256), Random.Range(0, 256), Random.Range(0, 256));
        if (gameObject.name != "KucukDusman")
        {
            yasam = Random.Range(5, 11);
        }
        gameObject.transform.localScale = new Vector3(yasam * 0.2f, yasam * 0.2f, 0.0f);
        hizCarpani = 1.0f;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0.0f, -hizCarpani);
    }
    public void yeniYasam(int can)
    {
        yasam = can;
    }
    public void vuruldu()
    {
        yasam -= 3;

        var kucukDusman1 = Instantiate(gameObject);
        var kucukDusman2 = Instantiate(gameObject);
        var konum = transform.position;
        kucukDusman1.transform.position = konum + new Vector3(2.0f, 0.0f, 0.0f);
        kucukDusman1.transform.position = konum + new Vector3(-2.0f, 0.0f, 0.0f);
        kucukDusman1.name = "KucukDusman";
        kucukDusman2.name = "KucukDusman";
        kucukDusman1.GetComponent<DusmanKod>().yeniYasam(yasam / 2);
        kucukDusman2.GetComponent<DusmanKod>().yeniYasam(yasam / 2);
        kucukDusman1.transform.localScale = new Vector3(yasam * 0.2f, yasam * 0.2f, 0.0f);
        kucukDusman2.transform.localScale = new Vector3(yasam * 0.2f, yasam * 0.2f, 0.0f);
        Destroy(gameObject);


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Mermi"))
        {
            if (yasam <= 0)
                Destroy(gameObject);
            else
                vuruldu();
            Destroy(collision.gameObject);
        }
        if (collision.name == "AltSinir" || collision.name == "Oyuncu")
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
