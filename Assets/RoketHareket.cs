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

        Invoke("Yoket", 2f); // 2 saniye sonra Yoket metodunu �al��t�r.
    }

    void Yoket()
    {
        Destroy(gameObject); // gameObject: Bu kodun ba�l� oldu�u nesneyi verir. O nesnenin yokedilmesini istiyoruz.
    }


    private void OnTriggerEnter(Collider other)
    {
        // Ba�ka bir nesneye temas etmi�se. (isTrigger se�ili olan bir nesne)

        if (other.gameObject.CompareTag("Dusman")) // E�er temas etti�imiz nesnenin Tag '� Dusman ise..
        {
            Destroy(other.gameObject); // Roketin temas etti�i nesneyi yoket.
            Destroy(gameObject); // Roketi de yoket.
        }
    }
}
