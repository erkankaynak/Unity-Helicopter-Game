using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoketHareket : MonoBehaviour
{
    // Helikopterimizden ��kan roketin hareketini ve �arpma kontrollerini
    // yapt���m�z kod.

    private Rigidbody rb;

    void Start()
    {
        // Mermiye ekledi�imiz RigidBody nesnesini al�p rb de�i�kenine aktar�yoruz.
        rb = GetComponent<Rigidbody>(); 
        
        
        // RigidBody kullanarak mermiye ileri y�nde bir kuvvet uyguluyoruz. 
        // Bu sayede mermi ileri do�ru f�rlay�p gidiyor.
        rb.AddForce(Vector3.forward * 5000f, ForceMode.Force);

        // 2 saniye sonra Yoket metodunu �al��t�r.
        // Bu sayede mermi sonsuza kadar ilerlemeyecek, hi� bir �eye �arpmasa bile
        // 2 saniye sonra yok olacak.
        Invoke("Yoket", 2f); 
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
