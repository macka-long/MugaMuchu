using UnityEngine;

public class MouseRotator : MonoBehaviour
{
    public float rotationSpeed = 100f;
    private bool isDragging = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            isDragging = true;

        if (Input.GetMouseButtonUp(0))
            isDragging = false;

        if (isDragging)
        {
            float mouseX = Input.GetAxis("Mouse X");
            transform.Rotate(Vector3.up, mouseX * rotationSpeed * Time.deltaTime);
        }
    }
}
