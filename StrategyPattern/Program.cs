// See https://aka.ms/new-console-template for more information

using StrategyPattern.Behaviour;
using StrategyPattern.Character;

Console.WriteLine("Welcome to Strategy Pattern!");

var player = new Player();
player.Jump();
player.SetJumpBehaviour(new SuperJump());
player.Jump();
player.SetJumpBehaviour(new NoJump());
player.Jump();

