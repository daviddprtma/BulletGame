using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 mouse;
    float kecepatan;
    Vector3 bergerak;
    // Start is called before the first frame update
    void Start()
    {
        kecepatan = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouse.z = 0;

            Vector3 arahBergerak = mouse - transform.position;
            Vector3 stepToMove = arahBergerak.normalized;
            bergerak = stepToMove * Time.deltaTime * kecepatan;
        }
        transform.position += bergerak;
    }
}
