using UnityEngine;

public class PlayerGroundedState : PlayerState
{
    protected Vector2 input;
    public PlayerGroundedState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }

    public override void doChecks()
    {
        base.doChecks();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        input = player.InputHandler.MovementInput;
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
