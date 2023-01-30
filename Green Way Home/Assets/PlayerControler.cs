using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    Rigidbody2D Rb;


    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        Rb.MovePosition(Rb.position + direction * speed * Time.fixedDeltaTime);
    }
}
