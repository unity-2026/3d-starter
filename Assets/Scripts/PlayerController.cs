using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("공을 미는 힘의 세기")]
    [SerializeField] float moveForce = 7.0f;

    Rigidbody rb;
    float moveX;
    float moveZ;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveX, 0.0f, moveZ);
        rb.AddForce(movement * moveForce);
    }
}
