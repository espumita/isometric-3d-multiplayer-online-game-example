using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public Transform target;

    void FixedUpdate() {
        var desiredPosition = target.position  + offset;
        var smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
