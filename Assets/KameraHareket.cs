using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class KameraHareket : MonoBehaviour
{
    public GameObject helikopter;
    public Vector3 offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.position = helikopter.transform.position + offset ;
    }
}
