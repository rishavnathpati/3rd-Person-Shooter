using UnityEngine;

public class CharacterAiming : MonoBehaviour
{
    [SerializeField] private float turnSpeed = 15f;
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        float yawCamera = _camera.transform.rotation.eulerAngles.y;
        transform.rotation =
            Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yawCamera, 0), turnSpeed * Time.deltaTime);
    }
}