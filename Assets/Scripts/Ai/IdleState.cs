using UnityEngine;

public class IdleState : BaseState
{
    private PlayerInput player;
    public override void OnStateEnter()
    {
        player = GameManager.Instance.GetPlayer();
    }

    public override void OnStateRun()
    {
        if(Vector3.Distance(controller.transform.position, player.transform.position) < 13f)
        {
            controller.ChangeState(new AimingState(player.transform));
        }
    }

    public override void OnStateExit()
    {
        
    }

}
