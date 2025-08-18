using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float rotationSpeed = 20f;
    private CarControls controls;
    private Vector2 moveInput;

    void Awake()
    {
        controls = new CarControls();

        // subscribing to input action
        controls.gameplay.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();

        controls.gameplay.Move.canceled += ctx => moveInput = Vector2.zero;
    }
    private void OnEnable()
    {
        controls.gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.gameplay.Disable();
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float forward = moveInput.y;
        // Will move the vehicle forward
        transform.Translate(Vector3.forward * forward * Time.deltaTime * speed);

        // will move the vehicle side to side
        float turn = moveInput.x;
        transform.Rotate(Vector3.up * turn * Time.deltaTime * rotationSpeed);
    }
}
