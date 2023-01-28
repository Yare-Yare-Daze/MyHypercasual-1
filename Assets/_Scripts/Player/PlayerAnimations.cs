using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private PlayerState _playerState;

    private void Start()
    {
        _playerState = GetComponent<PlayerState>();
    }

    private void Update()
    {
        if(_playerState.playerState == PlayerState.State.Finished)
        {
            animator.SetBool("isFinished", true);
        }
    }
}
