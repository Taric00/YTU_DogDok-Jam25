using UnityEngine;

public class CameraButtonMover : MonoBehaviour
{
    public Vector2 targetPosition2D;

    public void MoveCamera()
    {
        Vector3 cameraPosition = Camera.main.transform.position;

        Vector3 newPosition = new Vector3(targetPosition2D.x, targetPosition2D.y, cameraPosition.z);

        Camera.main.transform.position = newPosition;
    }
}
