using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu]
public class AIBrainBase : ScriptableObject
{
    public float speed;
    public float alertDist;
    public float attackDist;
    
    public int damage;

    public void Navigate(NavMeshAgent agent)
    {
        

    }
}

