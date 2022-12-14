using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public int objehizi;
    public Transform Sphere;
    public Transform Sphere2;
       void Update()
    {
        Sphere.Translate(0, 0, Input.GetAxis("Vertical")*objehizi * Time.deltaTime);
        Sphere2.Translate(Input.GetAxis("Horizontal")*objehizi*Time.deltaTime, 0, 0);
    }
}
