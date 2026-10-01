using UnityEngine;

public class RotateAnimator : MonoBehaviour
{
    Vector3 rotateSpeed = new Vector3(0, 45f, 0);

    void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime);
        // Debug.Log($"Time.deltaTime={Time.deltaTime}\n");
    }
}
