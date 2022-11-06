using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanFabrika : MonoBehaviour
{
    public GameObject dusmanPrefab;
    public float sinir = 20f;
    void Start()
    {
        InvokeRepeating("DusmanYarat", 1f, 1f); // 1 sonra DusmanYarat fonksiyonunu �al��t�r ve her 1 saniyede tekrar et.
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
