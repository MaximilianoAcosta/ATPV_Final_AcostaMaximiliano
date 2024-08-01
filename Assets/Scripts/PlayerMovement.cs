using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float mass;
    CharacterController characterController;
    Vector3 velocity;
    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        var input = new Vector3();
        input += transform.right * x;
        input += transform.forward * y;
        input = Vector3.ClampMagnitude(input, 1f);
        characterController.Move((input*movementSpeed+velocity)*Time.deltaTime);
        UpdateGravity();
        ExitGame();
    }

    private void UpdateGravity()
    {
        var gravity = Physics.gravity * mass * Time.deltaTime;
        velocity.y = characterController.isGrounded ? -1f : velocity.y + gravity.y;
        
    }

    private void ExitGame()
    {
        if (Input.GetButton("Cancel"))
        {
            Debug.Log("ExitGame");
            Application.Quit();
        }
    }
}
