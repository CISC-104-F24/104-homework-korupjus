using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float originalMoveSpeed = 50f;
    public float originalJumpPower = 50f;
    public float sprintMoveSpeed;
    public float powerJump = 1f;
    public float playerStamina;
    Vector3 forwardVector = Vector3.forward;
    Vector3 backwardVector = Vector3.forward * -1;
    Vector3 leftVector = Vector3.right * -1;
    Vector3 rightVector = Vector3.right;
    Vector3 movementDirection = Vector3.zero;
    Vector3 upVector = Vector3.up;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody myRb = GetComponent<Rigidbody>();
        movementDirection = movementDirection + forwardVector;
        movementDirection = movementDirection + backwardVector;
        movementDirection = movementDirection + leftVector;
        movementDirection = movementDirection + rightVector;
        movementDirection = movementDirection.normalized;
        bool isFowardPressed = false;
        isFowardPressed = Input.GetKey(KeyCode.W); //W
        if (isFowardPressed)
        {
            transform.position = transform.position + (originalMoveSpeed * sprintMoveSpeed * forwardVector * Time.deltaTime);
            //Debug.Log("W is pressed");
        }

        bool isBackwardPressed = false;
        isBackwardPressed = Input.GetKey(KeyCode.S); //S
        if (isBackwardPressed)
        {
            transform.position = transform.position + (originalMoveSpeed * sprintMoveSpeed * backwardVector * Time.deltaTime);
            //Debug.Log("S is pressed");
        }

        bool isLeftPressed = false;
        isLeftPressed = Input.GetKey(KeyCode.A); //A
        if (isLeftPressed)
        {
            transform.position = transform.position + (originalMoveSpeed * sprintMoveSpeed * leftVector * Time.deltaTime);
            //Debug.Log("A is pressed");
        }

        bool isRightPressed = false;
        isRightPressed = Input.GetKey(KeyCode.D); //D
        if (isRightPressed)
        {
            transform.position = transform.position + (originalMoveSpeed * sprintMoveSpeed * rightVector * Time.deltaTime);
            //Debug.Log("D is pressed");
        }

        bool isSpacePressed = false;
        isSpacePressed = Input.GetKeyDown(KeyCode.Space);
        if (isSpacePressed)
        {
            myRb.AddForce(upVector * originalJumpPower * powerJump, ForceMode.Impulse);
            //Debug.Log("Space is pressed");
        }

        bool isLeftControlPressed = false;
        isLeftControlPressed = Input.GetKey(KeyCode.LeftControl);
        if (isLeftControlPressed)
        {
            powerJump = powerJump + (1.5f * Time.deltaTime);
            //Debug.Log("L Control is pressed");
            if (powerJump > 3)
            {
                powerJump = 3;
            }
        }
        else
        {
            powerJump = powerJump - (1.5f * Time.deltaTime);
            if (powerJump < 1) //part d option 5
            {
                powerJump = 1; // part d option 5
            }
        }

        bool isLeftShiftPressed = false;
        isLeftShiftPressed = Input.GetKey(KeyCode.LeftShift);
        if (isLeftShiftPressed)
        {
            sprintMoveSpeed = 3f;
            playerStamina = playerStamina - Time.deltaTime; //part d option 4
            if (playerStamina <= 0f) //part d option 4
            {
                sprintMoveSpeed = 1f; //part d option 4
                playerStamina = 0f; //part d option 4
            }
            //Debug.Log("L Shift is pressed");
        }
        else
        {
            sprintMoveSpeed = 1f;
            playerStamina = playerStamina + Time.deltaTime; //part d option 4
            if (playerStamina > 10) //part d option 4
            {
                playerStamina = 10; //part d option 4
            }
        }

        bool isFPressed = false;
        isFPressed = Input.GetKeyDown(KeyCode.F);
        if (isFPressed)
        {
            Debug.Log("F is pressed");
            transform.localRotation = Quaternion.identity;
        }
    }
}

