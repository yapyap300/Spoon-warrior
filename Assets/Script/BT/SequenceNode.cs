using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceNode : INode
{
    List<INode> childs;

    public SequenceNode(List<INode> childs)
    {
        this.childs = childs;
    }

    public INode.NodeState Evaluate()
    {
        if (childs == null || childs.Count == 0)
            return INode.NodeState.Fail;

        foreach(var child in childs)
        {
            INode.NodeState current = child.Evaluate();
            if (current == INode.NodeState.Success) continue;

            return current;
        }

        return INode.NodeState.Success;
    }
}
