using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanHareket : MonoBehaviour
{

    // D��man helikopterlerin hareketlerini kodlad���m�z yer.


    public float hareketHiz = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * hareketHiz * Time.deltaTime); 
        
        // D��man helikopterinin y�n� zaten bize do�ru (back y�n�nde) oldu�u
        // i�in back yerine forward y�n�nde ilerlemesini istiyoruz.
    }
}
