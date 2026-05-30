using UnityEngine;

public class AimingState : BaseState
{
    private Transform turretHead;
    private Transform target;

    private float timer;
    private LineRenderer line;
    

    public override void OnStateEnter()
    {
        line = controller.GetComponentInChildren<LineRenderer>();
        line.enabled = true;
        

        turretHead = controller.transform.Find("Head");
    }

    public override void OnStateRun()
    {
        turretHead.LookAt(target.position + Vector3.up);
        if(Vector3.Distance(controller.transform.position, target.position) > 13f)
        {
            controller.ChangeState(new IdleState());
        }

        timer += Time.deltaTime;

        if(timer > 10f)
        {

        }
    }

    public override void OnStateExit()
    {
        //controller.GetComponentInChildren<LineRenderer>().enabled = false;
        line.enabled = false;
    }
    
    public AimingState(Transform newTarget)
    {
        target = newTarget;
    }
}
