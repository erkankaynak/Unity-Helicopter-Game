using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanHareket : MonoBehaviour
{
    public float hareketHiz = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * hareketHiz * Time.deltaTime); 
        
        // Düþman helikopterinin yönü zaten bize doðru olduðu için back yerine forward yönünde ilerlemesini istiyoruz.
    }
}
