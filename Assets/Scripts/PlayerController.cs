using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("공을 미는 힘의 세기")]
    [SerializeField] float moveForce = 7.0f;

    Rigidbody rb;
    float moveX;
    float moveZ;
    int collectCount = 0; // 아이템 획득 개수

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
    // 충돌 감지
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Item"))
        {

            collectCount++;
            Debug.Log($"[아이템 획득] 개수: {collectCount}개");
            Destroy(other.gameObject);
        }
    }
}
