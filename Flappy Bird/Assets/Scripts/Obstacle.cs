using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float speed;
    private void Start()
    {
        Destroy(gameObject, 10f);
    }
    void Update()
    {
        if(GameManager.started)
            transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
