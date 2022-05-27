using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Filter/Layer")]
public class LayerFilter : ContextFilter
{
    public LayerMask mask;

    public override List<Transform> Filter(FlockAgent agent, List<Transform> original)
    {
        List<Transform> filtered = new List<Transform>();
        foreach(Transform item in original)
        {
            //1      = 0000000000001
            //1 << 6 = 0000001000000

            //mask   = 0011011010001
            //mask   = 0000001000001

            //         0000001000000 |
            //         0000001000001
            //         0000001100001

            if (0 != ( mask & (1 << item.gameObject.layer)))
            {
                filtered.Add(item);
            }
        }
        return filtered;
    }
}
