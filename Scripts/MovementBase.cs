using Godot;
using System;

public class MovementBase : KinematicBody2D
{
	public int speed = 100;
	
	public int gravity = 1000;	
	public int slow;
	public Vector2 velocity = new Vector2();
	public bool jumping = false;
	string animation;
	int newState;
	int jumpSpeed = -600;
	
	public void currentState()
	{
		
		switch(newState)
		{
			case 0:
				animation = "jump";
				break;
			case 1:
				animation = "run";
				break;
		}
	}
	
	public void maxSpeed()
	{
		if (velocity.x > 500)
		{ velocity.x = 500; }
		else if (velocity.x < -500)
		{ velocity.x = -500; }
	}
	
	public void slowingDown()
	{
		if (jumping && IsOnFloor()==false)
		{ slow = 5; }
		else 
		{ slow = 5; }
		
		if (velocity.x < 0 || velocity.x > 0)
		{
			if(velocity.x <0)
			{
				velocity.x +=slow;
			} else {
				velocity.x -= slow;
			}
		}
	}
	
	public void GetInput()
	{
		bool jump = Input.IsActionPressed("up");

//Horizontal
	if (IsOnFloor())
	{
		if (Input.IsActionPressed("right"))
			{ velocity.x += speed; }

		if (Input.IsActionPressed("left"))
			{ velocity.x -= speed; }
	}
	else{
		if (Input.IsActionPressed("right"))
			{ velocity.x += speed/2; }

		if (Input.IsActionPressed("left"))
			{ velocity.x -= speed/2; }
	}
//Vertical 
		if (jump && IsOnFloor())
		{
			jumping = true;
			velocity.y = jumpSpeed; 
	}
		
	}

	public override void _PhysicsProcess(float delta)
	{
		GetInput();
		velocity.y += gravity * delta;
		//Slowing down without input for better control
		maxSpeed();
		slowingDown();

		if (jumping)
		{
			jumping = false;
		}
			
		velocity = MoveAndSlide(velocity, new Vector2(0, -1));

	}
}
