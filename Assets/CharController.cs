using UnityEngine;

public class CharController : MonoBehaviour {

    [SerializeField]
    public float moveSpeed = 6f;

    public Vector3 forward;
    public Vector3 right;

    // Start is called before the first frame update
    void Start() {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
    }

    // Update is called once per frame
    void Update() {
        if (Input.anyKey) {
            Move();
        }
    }

    private void Move() {
        var direction = new Vector3(Input.GetAxis("HorizontalKey"), 0, Input.GetAxis("VerticalKey"));
        var rightMovement = right * moveSpeed * Time.deltaTime * Input.GetAxis("HorizontalKey");
        var upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxis("VerticalKey");

        var heading = Vector3.Normalize(rightMovement + upMovement);

        transform.forward = heading;//Rotation

        transform.position += rightMovement; //Movement
        transform.position += upMovement;
    }
}
