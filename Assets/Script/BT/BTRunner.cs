using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTRunner
{
    INode rootNode;

    public BTRunner(INode rootNode)
    {
        this.rootNode = rootNode;
    }
    public void Operater()
    {
        rootNode.Evaluate();
    }
}
