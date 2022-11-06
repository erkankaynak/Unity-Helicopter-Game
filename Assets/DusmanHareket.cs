using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanHareket : MonoBehaviour
{

    // Düþman helikopterlerin hareketlerini kodladýðýmýz yer.


    public float hareketHiz = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * hareketHiz * Time.deltaTime); 
        
        // Düþman helikopterinin yönü zaten bize doðru (back yönünde) olduðu
        // için back yerine forward yönünde ilerlemesini istiyoruz.
    }
}
