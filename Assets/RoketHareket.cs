using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoketHareket : MonoBehaviour
{
    // Helikopterimizden çýkan roketin hareketini ve çarpma kontrollerini
    // yaptýðýmýz kod.

    private Rigidbody rb;

    void Start()
    {
        // Mermiye eklediðimiz RigidBody nesnesini alýp rb deðiþkenine aktarýyoruz.
        rb = GetComponent<Rigidbody>(); 
        
        
        // RigidBody kullanarak mermiye ileri yönde bir kuvvet uyguluyoruz. 
        // Bu sayede mermi ileri doðru fýrlayýp gidiyor.
        rb.AddForce(Vector3.forward * 5000f, ForceMode.Force);

        // 2 saniye sonra Yoket metodunu çalýþtýr.
        // Bu sayede mermi sonsuza kadar ilerlemeyecek, hiç bir þeye çarpmasa bile
        // 2 saniye sonra yok olacak.
        Invoke("Yoket", 2f); 
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
