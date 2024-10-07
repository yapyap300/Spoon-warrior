using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogre : Enemy
{
    public string hitAnim;
    public override INode SetTree()
    {
        throw new System.NotImplementedException();
    }
    bool IsAnimationRunning(string stateName)
    {
        if(animator != null)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName(stateName))
            {
                return true;
            }
        }

        return false;
    }

    INode.NodeState DetectHit()
    {
        return hitting ? INode.NodeState.Success : INode.NodeState.Fail;
    }
    INode.NodeState HitAction()
    {
        animator.SetTrigger(hitAnim);
        hitting = false;
        return INode.NodeState.Success;
    }
}
