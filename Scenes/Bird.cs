using Godot;
using System;

public partial class Bird : CharacterBody2D
{
	[Export] float Speed = 300.0f;
    [Export] float jumpVelocity = -400.0f;
	private bool crashed = false;
	public bool falling;

	public Vector2 flap = new Vector2();

    private AnimationPlayer _fly;

    public override void _Ready()
	{
		_fly = GetNode<AnimationPlayer>("FLY!");
	}

	public override void _PhysicsProcess(double delta)
	{
		if (crashed) return;

		{	flap = Velocity;
			// Add the gravity.
			if (!IsOnFloor())
			{
				flap += GetGravity() * (float)delta;
			}

			// Handle Jump.
			if (Input.IsActionJustPressed("flap"))
			{
				Flap();
			}
			Velocity = flap;
			MoveAndSlide();
		}
	}

	public void Reset()
	{
		//flying = false;
	}

	public void StopBird()
	{
		crashed = true;
	}

	public void Flap()
	{
		if (crashed) return;
		flap.Y = jumpVelocity;
		_fly.Play("fly");
    }
}
