using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HelikopterHareket : MonoBehaviour
{
    // Kulland���m�z helikopterin klavye ila hareketi, ate� etmesi ve 
    // �arpma kontrollerini yap�yoruz.

    public float hareketHiz = 30f;
    public float hareketSinir = 30f; // helikopterimiz x ekseninde  0 koordinat�nda duruyor.
                                    // -30 ve +30 aras�nda hareket edebilsin; ama bu s�n�rlar�,
                                    // a�amas�n istiyoruz.

    public GameObject roketPrefab;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -hareketSinir) // belirledi�imiz s�n�rdan daha fazla sola gelmesin istiyoruz.
                transform.Translate(Vector3.left * hareketHiz * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < hareketSinir) // Belirledi�imiz s�n�rdan daha fazla sa�a gelmesin istiyoruz.
                transform.Translate(Vector3.right * hareketHiz * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(roketPrefab, transform.position + Vector3.forward * 2, Quaternion.identity);
            // ilk parametre: hangi nesneden yaratmak istiyoruz.
            // ikinci parametre: nerede yaratmak istiyoruz. Helikopterin biraz �n�nde yarat�yoruz ki
            // bize �arpmas�n :)
            // ���nc� parametre: hangi y�ne baks�n. Nesne nas�l tasarlanm�� ise o �ekilde getirdik.

        }
    }
}
