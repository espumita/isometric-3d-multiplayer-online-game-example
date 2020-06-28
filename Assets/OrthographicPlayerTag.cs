using UnityEngine;

public class OrthographicPlayerTag : MonoBehaviour {
    private Transform playerCameraTransform;

    private void Start() {
        playerCameraTransform = Camera.main.transform;
    }

    private void LateUpdate() {
        transform.LookAt(transform.position + playerCameraTransform.rotation * Vector3.forward, playerCameraTransform.rotation * Vector3.up);
    }

}

