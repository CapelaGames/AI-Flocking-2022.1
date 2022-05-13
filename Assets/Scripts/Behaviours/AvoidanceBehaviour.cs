using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behaviour/Avoidance")]
public class AvoidanceBehaviour : FlockBehaviour
{
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        if (context.Count == 0)
        {
            return Vector2.zero;
        }

        Vector2 avoidanceMove = Vector2.zero;
        int count = 0;
        foreach (Transform item in context)
        {
            avoidanceMove += (Vector2)(agent.transform.position - item.position);
            count++;
        }

        if (count != 0)
        {
            avoidanceMove /= count;
        }

        return avoidanceMove;
    }
}


