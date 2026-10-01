using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("추적 대상")]
    [Tooltip("카메라가 따라다닐 타겟 객체입니다.")]
    [SerializeField] GameObject player;

    Vector3 offset; // 카메라와 Player 사이의 고정된 간격

    void Start()
    {
        //        카메라의 위치          플레이어의 위치
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        // 카메라의 위치 변경      플레이어의 위치에 offset 초기값을 더한다
        transform.position = player.transform.position + offset;
    }
}
