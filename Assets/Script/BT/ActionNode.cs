using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActionNode : INode
{
    Func<INode.NodeState> onUpdate = null;

    public ActionNode(Func<INode.NodeState> onUpdate)
    {
        this.onUpdate = onUpdate;
    }
    public INode.NodeState Evaluate()
    {
        return onUpdate?.Invoke() ?? INode.NodeState.Fail;
    }
}
