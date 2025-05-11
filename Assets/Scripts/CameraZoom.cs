using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float zoomSpeed = 5f;
    public float minDistance = 1f;
    public float maxDistance = 10f;
    public Transform target; // ƒ‚ƒfƒ‹‚È‚Ç’Ž‹“_

    void Update()
    {
        if (target == null) return;

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (Mathf.Abs(scroll) > 0.01f)
        {
            Vector3 direction = (transform.position - target.position).normalized;
            Vector3 newPos = transform.position + direction * scroll * zoomSpeed;

            float distance = Vector3.Distance(newPos, target.position);
            if (distance >= minDistance && distance <= maxDistance)
                transform.position = newPos;
        }
    }
}
