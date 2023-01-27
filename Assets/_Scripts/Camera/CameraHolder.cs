using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Vector3 initRotation;

    private void Awake()
    {
        initRotation = transform.eulerAngles;
    }

    private void Update()
    {
        transform.position = new Vector3(playerTransform.position.x, playerTransform.transform.position.y, playerTransform.position.z);

        transform.eulerAngles = new Vector3(playerTransform.eulerAngles.x + initRotation.x, playerTransform.eulerAngles.y + initRotation.y, 0);
    }
}
