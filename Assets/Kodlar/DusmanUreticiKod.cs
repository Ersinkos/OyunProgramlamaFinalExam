using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanUreticiKod : MonoBehaviour
{
    float uretmeSol;
    float uretmeSag;
    float uretmeY;
    [SerializeField] GameObject dusmanSablonu;
    float dusmanUretmeAraligi = 2.0f;
    float gecenSure = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        uretmeSol = GameObject.Find("DusmanUretmeNoktasiSol").transform.position.x;
        uretmeSag = GameObject.Find("DusmanUretmeNoktasiSag").transform.position.x;
        uretmeY = GameObject.Find("DusmanUretmeNoktasiSag").transform.position.y;
    }
    private void FixedUpdate()
    {
        if (gecenSure >= dusmanUretmeAraligi)
        {
            var dusman = Instantiate(dusmanSablonu);

            float uretmeX = Random.Range(uretmeSol, uretmeSag);

            dusman.transform.position = new Vector3(uretmeX, uretmeY, 0.0f);

            gecenSure = 0.0f;
        }
        gecenSure += Time.fixedDeltaTime;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
