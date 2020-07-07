using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public Transform target;

    void FixedUpdate() {
        MakeSmoothCameraMoveToTarget();
    }

    private void MakeSmoothCameraMoveToTarget() {
        var cameraNextPosition = target.position + offset;
        var smoothedNextCameraPosition = Vector3.Lerp(transform.position, cameraNextPosition, smoothSpeed);
        transform.position = smoothedNextCameraPosition;
    }
}
