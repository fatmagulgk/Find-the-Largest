using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearManager : MonoBehaviour
{
    public int speed = 30;
    void Update()
    {
        transform.Rotate(transform.forward * speed * Time.deltaTime);//Bu nesnenin rotasyonunu cevir.
    }
}
