using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelikopterPervane : MonoBehaviour
{

    private float donusHizi = 500f;

    void Update()
    {
        transform.Rotate(Vector3.up * donusHizi * Time.deltaTime);
    }
}
