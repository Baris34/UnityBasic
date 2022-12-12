using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public int x, y, z = 0;
    void Update()
    {
        transform.Rotate(new Vector3(x,y,z));
        
        
    }
}
