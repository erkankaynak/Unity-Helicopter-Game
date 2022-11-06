using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DenizHareket : MonoBehaviour
{
    public float hareketHiz = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * hareketHiz * Time.deltaTime);

        if (transform.position.z <= -50) transform.position += new Vector3(0,0,350f);
    }
}
