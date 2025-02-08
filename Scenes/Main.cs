using Godot;
using System;

public partial class Main : Node2D
{
	bool gameRunning;
	bool gameOver;
	int scroll;
	int score;
	Vector2 screenSize;
	int groundHeight;
	private const int ScrollSpeed = 4;
	private const int PipeDelay = 100;
	private const int PipeRange = 200;

	Bird bird;
	Ground ground;

	[Export]
	public PackedScene pipeScene { get; set; }

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		screenSize.X = GetViewportRect().Size.X;
		screenSize.Y = GetViewportRect().Size.Y;
		NewGame();
	}
	
	public void NewGame()
	{
		gameRunning = false;
		gameOver = false;
		score = 0;
		scroll = 0;
		bird.Reset();
	}

    public void StartGame()
	{
		gameRunning = true;
		bird.flying = true;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (gameRunning)
		{
			scroll += ScrollSpeed;
			if (scroll >= screenSize.X)
			{
				scroll = 0;
			}
            ground.Position = new Vector2(scroll, ground.Position.Y);

		}
	}
}
