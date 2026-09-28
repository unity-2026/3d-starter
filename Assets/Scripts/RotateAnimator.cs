using UnityEngine;

public class RotateAnimator : MonoBehaviour
{
    Vector3 rotateSpeed = new Vector3(15f, 30f, 45f);

    void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime);
        // Debug.Log($"Time.deltaTime={Time.deltaTime}\n");
    }
}
