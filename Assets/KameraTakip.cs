using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public Transform helikopter;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate metodu sahnede frame ile ilgili her þey bittikten sonra, 
    // yani herkesin update ile ilgili iþlemleri bittikten sonra çalýþýr.
    // Bu yüzden kamera konumlandýrmalarýnda bu metodu kullanabiliriz. Çünkü
    // takip edeceðimiz nesnenin yerleþiminin tamamen bittiðinden emin oluruz.

    void LateUpdate()
    {
        transform.position = helikopter.position + offset;
    }
}
