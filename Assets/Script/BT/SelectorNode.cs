using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorNode : INode
{
    List<INode> childs;

    public SelectorNode(List<INode> childs)
    {
        this.childs = childs;
    }

    public INode.NodeState Evaluate()
    {
        if (childs == null)
            return INode.NodeState.Fail;

        foreach(var child in childs)
        {
            INode.NodeState current = child.Evaluate();
            if (current == INode.NodeState.Fail) continue;

            return current;
        }

        return INode.NodeState.Fail;
    }
}
