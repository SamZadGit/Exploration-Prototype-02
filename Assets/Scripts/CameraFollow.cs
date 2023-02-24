using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float speed = 2f;
    private Vector3 offset = new Vector3(0f, 1.5f, -2f);

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 desiredPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPos, speed * Time.deltaTime);
    }
}
