using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector2 startingPos;
    void Update()
    {
        if (GameManager.started)
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        if(transform.position.x <= -1)
        {
            transform.position = startingPos;
        }
    }
}
