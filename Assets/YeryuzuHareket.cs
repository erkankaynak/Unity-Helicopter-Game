using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class YeryuzuHareket : MonoBehaviour
{
    // Oyunun arka planýndaki deniz ve daðlarýn animasyonunu yapýyoruz.

    public float hareketHiz = 10f;


    void Update()
    {
        transform.Translate(Vector3.back * hareketHiz * Time.deltaTime);
        // Aþaðýyda doðru sabit hýzla ilerletiyoruz.


        if (transform.position.z <= -50) transform.position += new Vector3(0,0,350f);
        // Eðer Z ekseninde -50 noktasýna gelirse, artýk kameranýn görüþ alanýndan çýkmýþ demektir.
        // Daha fazla gitmeden önce Z ekseninde 350 noktasýna gönderiyoruz ve yukarýdan yine 
        // gelmeye devam ediyor. 

        // Yeryüzü ile ilgili tüm nesnelere bu hareketi yapýyoruz ve
        // hiç kesinti olmadan sürekli gidiyormuþuz gibi görünmeye devam ediyor.
    }
}
