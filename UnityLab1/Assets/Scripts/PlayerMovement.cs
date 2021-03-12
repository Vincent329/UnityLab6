using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D m_rb;

    [SerializeField]
    private float m_fMoveSpeed = 5.0f;

    private Vector2 moveDirection;

    [SerializeField]
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        HandleInputs();
    }
    public int GetScore()
    {
        return score;
    }

    private void FixedUpdate()
    {
        MoveCharacter();
    }

    private void HandleInputs()
    {
        float m_fMoveX = Input.GetAxisRaw("Horizontal");
        float m_fMoveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector3(m_fMoveX, m_fMoveY).normalized;
    }
    private void MoveCharacter()
    {
        m_rb.velocity = new Vector2(moveDirection.x * m_fMoveSpeed, moveDirection.y * m_fMoveSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Update");
            score++;
         
        }
        
    }

}
