using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float Speed;
    [SerializeField]
    int FloatTime;
    [SerializeField]
    Transform StartPlace;
    [SerializeField]
    GameObject CurrentPlayer;
    [SerializeField]
    int Players; //0 is AI, 1 is player1, 2 is player2

    bool IsDead;
    bool IsFloat;
    Transform BubblePlace;
    GameObject Tools;
    string HorizontalInput = "Horizontal"; 
    string VerticalInput = "Vertical";
    private Rigidbody2D Rigidbody;

    private void Start()
    {
       Rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (!IsDead)
        {
            if (!IsFloat)
            {
                Move();
            }
        }

    }
    void Initiate(Transform StartSpace)
    {
        switch (Players)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
        }
    }

    void Move()
    {
        Vector2 movement = Vector2.zero;
        switch (Players)
        {
            case 0:
                break;
            case 1:
                movement.x = Input.GetAxisRaw("Horizontal");
                movement.y = Input.GetAxisRaw("Vertical");
                break;
            case 2:
                movement.x = 0;
                movement.y = 0;
                if (Input.GetKey(KeyCode.A)) movement.x = -1;
                if (Input.GetKey(KeyCode.D)) movement.x = 1;
                if (Input.GetKey(KeyCode.W)) movement.y = 1;
                if (Input.GetKey(KeyCode.S)) movement.y = -1;
                break;
        }
         movement = movement.normalized;
         Rigidbody.linearVelocity = movement * Speed;
        }

    void Fire()
    {
        
    }

    void Tap()
    {

    }

    bool Die()
    {
        return IsDead;
    }

    bool Float()
    {
        return IsFloat;
    }

    GameObject Pick()
    {
        return Tools;
    }

    void UseTools(GameObject Tool)
    {

    }


}
