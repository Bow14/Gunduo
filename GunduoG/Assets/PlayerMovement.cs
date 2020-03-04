using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMovement : MonoBehaviour
{

	public CharacterController controller;

	public float speed = 12f;
	public float gravity = -9.81f;
	public float jumpHeight = 3f;
	public float walkSpeed = 60f;
	public float sprintSpeed = 100f;

	public Transform groundCheck;
	public float groundDistance = 0.4f;
	public LayerMask groundMask;
	
	private Vector3 velocity;
	bool isGrounded;
	

	void Update ()
	{
		isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
		

		if (isGrounded && velocity.y < 0)
		{
			velocity.y = -8f;
		}
		
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");

		Vector3 move = transform.right * x + transform.forward * y;

		controller.Move(move * speed * Time.deltaTime);

		if (Input.GetButtonDown("Jump") && isGrounded)
		{
			velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
			
		} 
		if (Input.GetKey(KeyCode.LeftShift))
		{
			speed = sprintSpeed;
		}
		else
		{
			speed = walkSpeed;
		}
		
		velocity.y += gravity * Time.deltaTime;

		controller.Move(velocity * Time.deltaTime);
		
	}
	
	
	public float IncreaseSpeed(float multiplier)
	{
		return speed * multiplier;
	}
}
