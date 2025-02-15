using Godot;
using System;

public partial class Pipe : Node2D
{
	[Signal]
	public delegate void HitEventHandler();

	public void OnBodyEntered (Node2D body)
	{
		EmitSignal(SignalName.Hit);
	}

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
