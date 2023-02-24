using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorBehavior : MonoBehaviour
{
    private Transform cursorTransform;

    void Start()
    {
        cursorTransform = this.transform;
    }

    void Update()
    {
        LAMouse();
    }

    private void LAMouse()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - cursorTransform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

        cursorTransform.rotation = rotation;

    }
}
