using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    public float turnSpeed;
    public InputAction playerControls;
    Vector3 moveDirection = Vector3.zero;

    private float horizontalInput;

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Will move the vehicle forward
        transform.Translate(moveDirection * Time.deltaTime * speed);

        // will move the vehicle side to side
        // transform.Translate(moveDirection * Time.deltaTime * turnSpeed);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        moveDirection = playerControls.ReadValue<Vector3>();
        horizontalInput = Input.GetAxis("Horizontal");
        
    }
}
