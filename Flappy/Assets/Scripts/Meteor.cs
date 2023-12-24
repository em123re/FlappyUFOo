using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float hareketHizi = 3f;
    float solKameraNok;
    private void Start()
    {
        solKameraNok = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }
    public void Update()
    {
        transform.position += Vector3.left * hareketHizi * Time.deltaTime;

        if(transform.position.x < solKameraNok)
        {
            Destroy(gameObject);
        }
    }
}
