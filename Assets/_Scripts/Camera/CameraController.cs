using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Vector3 initPosition;
    [SerializeField] private Vector3 maxPosition;
    [SerializeField][Range(0f, 1f)] private float progress;

    private void Awake()
    {
        transform.localPosition = initPosition;
    }

    private void LateUpdate()
    {
        transform.localPosition = Vector3.Lerp(initPosition, maxPosition, progress);
    }
}
