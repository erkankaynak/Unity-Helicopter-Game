using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanFabrika : MonoBehaviour
{
    // Düþman helikopterlerin yaratýldýðý bölüm.


    public GameObject dusmanPrefab;
    public float sinir = 20f; // Düþmanlarýn yaratýlacaðý Y ve Z noktalarý belli.
                             // X ekseni ise rastgele seçilecek. Fakat bunu belirli bir sýnýr
                             // içerisinde yapmak istiyoruz.

    void Start()
    {
        // 1 sonra DusmanYarat fonksiyonunu çalýþtýr ve her 1 saniyede tekrar et.
        InvokeRepeating("DusmanYarat", 1f, 1f); 
    }

    void DusmanYarat()
    {
        float x = Random.Range(-sinir, sinir); // Yatay eksende rastgele bir yer seçmek için.

        Instantiate(dusmanPrefab, new Vector3(x, transform.position.y, transform.position.z ), Quaternion.LookRotation(Vector3.back));
        // x noktasý rastgele seçildi.
        // y noktasý Fabrika nesnesinin y kooordinatý ile ayný
        // z noktasý Fabrika nesnesinin z koordinatý ile ayný

        //  Quaternion.LookRotation(Vector3.back): Düþmanýn yönü bize doðru dönmesi için Vector3.Back yönünde canlandýrýyoruz.

    }
}
