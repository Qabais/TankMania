using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node 
{
    /// <summary>
    ///  Stores the postion and status of the node. 
    /// </summary>


    public bool walkable;
    public Vector3 worldPos;
    public int gridX;
    public int gridY;

    public int gCost;
    public int hCost;
    public Node parent;
    int heapIndex;

    public Node(bool _walkable, Vector3 _worldPos, int _gridX, int _gridY)
    {
        walkable = _walkable;
        worldPos = _worldPos;
        gridX = _gridX;
        gridY = _gridY;
    }


    public int fCost
    {
        get { return gCost + hCost; }
    }

    public int HeapIndex
    {
        get
        {
            return heapIndex;
        }
        set
        {
            heapIndex = value;
        }
    }

    public int CompareTo(Node nodeCompare)
    {
        int compare = fCost.CompareTo(nodeCompare.fCost);
        if (compare == 0)
        {
            compare = hCost.CompareTo(nodeCompare.hCost);
        }
        return -compare;
    }
}
