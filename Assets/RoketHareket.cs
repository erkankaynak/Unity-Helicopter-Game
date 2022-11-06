using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoketHareket : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * 5000f, ForceMode.Force);

        Invoke("Yoket", 2f); // 2 saniye sonra Yoket metodunu çalýþtýr.
    }

    void Yoket()
    {
        Destroy(gameObject); // gameObject: Bu kodun baðlý olduðu nesneyi verir. O nesnenin yokedilmesini istiyoruz.
    }


    private void OnTriggerEnter(Collider other)
    {
        // Baþka bir nesneye temas etmiþse. (isTrigger seçili olan bir nesne)

        if (other.gameObject.CompareTag("Dusman")) // Eðer temas ettiðimiz nesnenin Tag 'ý Dusman ise..
        {
            Destroy(other.gameObject); // Roketin temas ettiði nesneyi yoket.
            Destroy(gameObject); // Roketi de yoket.
        }
    }
}
