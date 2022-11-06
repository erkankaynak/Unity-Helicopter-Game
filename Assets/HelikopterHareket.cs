using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HelikopterHareket : MonoBehaviour
{
    public float hareketHiz = 30f;
    public float hareketSinir = 30f;

    public GameObject roketPrefab;

    
    void Start()
    {
        
    }


    private void Update()
    {
        var yeniKoordinat = Vector3.right * Input.GetAxis("Mouse X") * hareketHiz * Time.deltaTime;

        if (yeniKoordinat.x > -hareketSinir && yeniKoordinat.x < hareketSinir)
            transform.Translate(yeniKoordinat); // Farenin yatay eksende hareketi kadar biz de hareket edelim.



        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(roketPrefab, transform.position + Vector3.forward * 2, Quaternion.identity);
        }
    }
}
