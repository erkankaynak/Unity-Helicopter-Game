using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class YeryuzuHareket : MonoBehaviour
{
    // Oyunun arka plan�ndaki deniz ve da�lar�n animasyonunu yap�yoruz.

    public float hareketHiz = 10f;


    void Update()
    {
        transform.Translate(Vector3.back * hareketHiz * Time.deltaTime);
        // A�a��yda do�ru sabit h�zla ilerletiyoruz.


        if (transform.position.z <= -50) transform.position += new Vector3(0,0,350f);
        // E�er Z ekseninde -50 noktas�na gelirse, art�k kameran�n g�r�� alan�ndan ��km�� demektir.
        // Daha fazla gitmeden �nce Z ekseninde 350 noktas�na g�nderiyoruz ve yukar�dan yine 
        // gelmeye devam ediyor. 

        // Yery�z� ile ilgili t�m nesnelere bu hareketi yap�yoruz ve
        // hi� kesinti olmadan s�rekli gidiyormu�uz gibi g�r�nmeye devam ediyor.
    }
}
