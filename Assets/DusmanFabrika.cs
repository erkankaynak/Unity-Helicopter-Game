using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanFabrika : MonoBehaviour
{
    // D��man helikopterlerin yarat�ld��� b�l�m.


    public GameObject dusmanPrefab;
    public float sinir = 20f; // D��manlar�n yarat�laca�� Y ve Z noktalar� belli.
                             // X ekseni ise rastgele se�ilecek. Fakat bunu belirli bir s�n�r
                             // i�erisinde yapmak istiyoruz.

    void Start()
    {
        // 1 sonra DusmanYarat fonksiyonunu �al��t�r ve her 1 saniyede tekrar et.
        InvokeRepeating("DusmanYarat", 1f, 1f); 
    }

    void DusmanYarat()
    {
        float x = Random.Range(-sinir, sinir); // Yatay eksende rastgele bir yer se�mek i�in.

        Instantiate(dusmanPrefab, new Vector3(x, transform.position.y, transform.position.z ), Quaternion.LookRotation(Vector3.back));
        // x noktas� rastgele se�ildi.
        // y noktas� Fabrika nesnesinin y kooordinat� ile ayn�
        // z noktas� Fabrika nesnesinin z koordinat� ile ayn�

        //  Quaternion.LookRotation(Vector3.back): D��man�n y�n� bize do�ru d�nmesi i�in Vector3.Back y�n�nde canland�r�yoruz.

    }
}
