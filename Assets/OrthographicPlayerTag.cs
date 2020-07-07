using UnityEngine;

public class OrthographicPlayerTag : MonoBehaviour {
    private Transform playerCameraTransform;

    private void Start() {
        playerCameraTransform = Camera.main.transform;
    }

    private void LateUpdate() {
        KeepTagIsometric();
    }

    private void KeepTagIsometric() {
        var cameraOrthographicForward = transform.position + playerCameraTransform.rotation * Vector3.forward;
        var cameraOrthographicUp = playerCameraTransform.rotation * Vector3.up;
        transform.LookAt(cameraOrthographicForward, cameraOrthographicUp);
    }

}

