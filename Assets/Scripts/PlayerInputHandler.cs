using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    [field:SerializeField] public PlayerInput playerInput { get; private set; }
    public Vector2 MovementInput { get; private set; }

    public void OnMove(InputAction.CallbackContext context)
    {
        MovementInput = context.ReadValue<Vector2>();
        Debug.Log(MovementInput);
    }

    public void OnJump(InputAction context)
    {

    }
}
