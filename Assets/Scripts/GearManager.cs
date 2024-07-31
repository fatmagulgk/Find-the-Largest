using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearManager : MonoBehaviour
{
    public int speeed = 30;
    void Update()
    {
        transform.Rotate(transform.forward * speeed * Time.deltaTime);//Bu nesnenin rotasyonunu cevir.
    }
}
