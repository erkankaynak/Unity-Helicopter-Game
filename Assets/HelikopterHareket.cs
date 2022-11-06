using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HelikopterHareket : MonoBehaviour
{
    // Kullandýðýmýz helikopterin klavye ila hareketi, ateþ etmesi ve 
    // çarpma kontrollerini yapýyoruz.

    public float hareketHiz = 30f;
    public float hareketSinir = 30f; // helikopterimiz x ekseninde  0 koordinatýnda duruyor.
                                    // -30 ve +30 arasýnda hareket edebilsin; ama bu sýnýrlarý,
                                    // aþamasýn istiyoruz.

    public GameObject roketPrefab;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -hareketSinir) // belirlediðimiz sýnýrdan daha fazla sola gelmesin istiyoruz.
                transform.Translate(Vector3.left * hareketHiz * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < hareketSinir) // Belirlediðimiz sýnýrdan daha fazla saða gelmesin istiyoruz.
                transform.Translate(Vector3.right * hareketHiz * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(roketPrefab, transform.position + Vector3.forward * 2, Quaternion.identity);
            // ilk parametre: hangi nesneden yaratmak istiyoruz.
            // ikinci parametre: nerede yaratmak istiyoruz. Helikopterin biraz önünde yaratýyoruz ki
            // bize çarpmasýn :)
            // üçüncü parametre: hangi yöne baksýn. Nesne nasýl tasarlanmýþ ise o þekilde getirdik.

        }
    }
}
