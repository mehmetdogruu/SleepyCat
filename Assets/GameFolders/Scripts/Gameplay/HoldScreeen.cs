﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldScreeen : MonoBehaviour
{
 
    void Update()
    {
        if (transform.position.x<-EkranHesaplayicisi.instance.Genislik)
        {
            Vector2 temp = transform.position;
            temp.x = -EkranHesaplayicisi.instance.Genislik;
            transform.position = temp;
        }
        if (transform.position.x > EkranHesaplayicisi.instance.Genislik)
        {
            Vector2 temp = transform.position;
            temp.x = EkranHesaplayicisi.instance.Genislik;
            transform.position = temp;
        }
    }
}