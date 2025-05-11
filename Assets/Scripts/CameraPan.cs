using UnityEngine;

public class CameraPan : MonoBehaviour
{
    public float panSpeed = 0.5f;
    private Vector3 lastMousePosition;
    private bool isPanning = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            lastMousePosition = Input.mousePosition;
            isPanning = true;
        }

        if (Input.GetMouseButtonUp(2))
        {
            isPanning = false;
        }

        if (isPanning)
        {
            Vector3 delta = Input.mousePosition - lastMousePosition;
            Vector3 move = new Vector3(-delta.x, -delta.y, 0) * panSpeed * Time.deltaTime;

            // ���E���W�ňړ�������i��ɐ����E�����ɓ����j
            transform.Translate(move, Space.World);

            lastMousePosition = Input.mousePosition;
        }
    }
}
