using Godot;
using System;

public partial class Main : Node2D
{
	Bird player;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
    }
	
	public void NewGame()
	{
		
	}

    public override void _Input(InputEvent @event)
	{
		if (@event is InputEventKey space && space.Pressed)
		{
			//player.flying = true;
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
}
