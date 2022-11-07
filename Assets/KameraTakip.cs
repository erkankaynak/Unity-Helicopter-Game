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

    // LateUpdate metodu sahnede frame ile ilgili her �ey bittikten sonra, 
    // yani herkesin update ile ilgili i�lemleri bittikten sonra �al���r.
    // Bu y�zden kamera konumland�rmalar�nda bu metodu kullanabiliriz. ��nk�
    // takip edece�imiz nesnenin yerle�iminin tamamen bitti�inden emin oluruz.

    void LateUpdate()
    {
        transform.position = helikopter.position + offset;
    }
}
