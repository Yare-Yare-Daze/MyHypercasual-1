using UnityEngine;

public class PlayerFinished : MonoBehaviour
{
    [SerializeField] private Transform dancePlace;
    private PlayerState _playerState;
    private bool onDancePlace; 

    private void Start()
    {
        onDancePlace= false;
        Debug.Log("Player placed: " + onDancePlace);
        _playerState = GetComponent<PlayerState>();
    }

    private void LateUpdate()
    {
        if(_playerState.playerState == PlayerState.State.Finished && !onDancePlace)
        {
            //transform.position = new Vector3(dancePlace.position.x, dancePlace.position.y, dancePlace.position.z);
            transform.position = dancePlace.position;
            transform.eulerAngles = dancePlace.eulerAngles;
            onDancePlace = true;
            Debug.Log("Player placed: " + onDancePlace);
        }
    }


}
