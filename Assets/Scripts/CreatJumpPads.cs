using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatJumpPads : MonoBehaviour
{
    private int maxJumpPads;
    private Transform cursorTransform;

    public Manager UiManager;

    public GameObject dotPrefab;
    void Start()
    {
        cursorTransform = this.transform;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && maxJumpPads < 30f)
        {
            Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - cursorTransform.position;

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject x = Instantiate(dotPrefab, (Vector2)spawnPosition.normalized, Quaternion.AngleAxis(angle + 90, Vector3.forward));
            maxJumpPads++;
            UiManager.jumpPadCount++;
        }
    }
}
