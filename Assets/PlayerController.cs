using Photon.Pun;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviourPunCallbacks {

    public Camera Camera;
    public NavMeshAgent Agent;

    void Start() {
        if (!photonView.IsMine) {
            Camera.enabled = false;
            GetComponentInChildren<AudioListener>().enabled = false;
        }
    }

    void Update() {
        if (!photonView.IsMine) return;
        if (Input.GetMouseButton(0)) {
            var ray = Camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            var hitSomething = Physics.Raycast(ray, out hit);

            if (hitSomething) {
                ModeAgentTo(hit);
            }

        }
    }

    private void ModeAgentTo(RaycastHit hit) {
        Agent.SetDestination(hit.point);
    }
}
