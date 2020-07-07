using UnityEngine;

public class CameraFollowTarget : MonoBehaviour {

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public Transform targetToFollow;

    void FixedUpdate() {
        MakeSmoothCameraMoveToTarget();
    }

    private void MakeSmoothCameraMoveToTarget() {
        var cameraNextPosition = targetToFollow.position + offset;
        var smoothedNextCameraPosition = Vector3.Lerp(transform.position, cameraNextPosition, smoothSpeed);
        transform.position = smoothedNextCameraPosition;
    }
}
