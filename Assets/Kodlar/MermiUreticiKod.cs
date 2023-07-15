using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiUreticiKod : MonoBehaviour
{
    [SerializeField] Transform mermiUretmeNoktasi;
    [SerializeField] GameObject mermiSablon;
    public float mermiAtilmaSuresi = 0.2f;
    public float oncekiMermiSuresi = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (oncekiMermiSuresi >= mermiAtilmaSuresi)
            {
                var yeniMermi = Instantiate(mermiSablon);
                yeniMermi.transform.position = mermiUretmeNoktasi.position + yeniMermi.transform.localScale * 0.5f;

                oncekiMermiSuresi = 0.0f;
            }
            oncekiMermiSuresi += Time.deltaTime;
        }
    }
}
