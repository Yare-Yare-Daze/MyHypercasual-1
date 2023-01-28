using PathCreation.Examples;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public enum State
    {
        Running = 0,
        Finished
    }

    private PathFollower pathFollowerGO;
    private PlayerMovement playerMovementGO;

    public State playerState = State.Running;

    private void Awake()
    {
        pathFollowerGO = GetComponent<PathFollower>();
        playerMovementGO = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if(playerState == State.Finished && (playerMovementGO.isActiveAndEnabled || pathFollowerGO.isActiveAndEnabled))
        {
            playerMovementGO.enabled = false;
            pathFollowerGO.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            Debug.Log("Finish detected!");
            playerState = State.Finished;
        }
    }
}
