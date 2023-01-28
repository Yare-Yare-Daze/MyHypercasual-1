using UnityEngine;

public class CameraFinished : MonoBehaviour
{
    [SerializeField] private Vector3 localFinishPostion;
    [SerializeField] private Vector3 localFinishEulerAngle;
    [SerializeField] private float speedLerp;
    [SerializeField] private PlayerState playerState;
    private bool onFinishPlace;
    private CameraController cameraController;

    private void Start()
    {
        cameraController = GetComponent<CameraController>();
        onFinishPlace = false;
    }

    private void LateUpdate()
    {
        if(playerState.playerState == PlayerState.State.Finished)
        {
            cameraController.enabled = false;
            transform.localPosition = Vector3.Lerp(transform.localPosition, localFinishPostion, speedLerp * Time.deltaTime);
            transform.localEulerAngles = Vector3.Lerp(transform.localEulerAngles, localFinishEulerAngle, speedLerp * Time.deltaTime);
            
            onFinishPlace = true;
        }
    }


}
