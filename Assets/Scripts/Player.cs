using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Vector2 lastMovementInput;
    [SerializeField]
    private CharacterController cc;
    // Update is called once per frame
    void Update()
    {
        if (cc != null)
        {
            cc.Move(lastMovementInput * Time.deltaTime);
        }
    }


    public void MovementInput(InputAction. CallbackContext context)
    {
        lastMovementInput = context.ReadValue<Vector2>();
    }



}
