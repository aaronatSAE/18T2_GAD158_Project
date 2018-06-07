// Written by Aaron Goss

using UnityEngine;

public class MoveToTargetOverTime : MonoBehaviour
{
    /// <summary>
    /// The target that this object will move towards.
    /// </summary>
    [SerializeField] Transform target;

    /// <summary>
    /// The percentage of distance this object will cover
    /// per second, while moving towards the target's position.
    /// 1 = 100% and 0 = 0%
    /// </summary>
    [SerializeField] float percentage = 0.02f;

    // Update is called once per frame
    private void Update()
    {
        if (target)
        {
            Move();
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (target)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, target.position);
        }
    }

    /// <summary>
    /// Moves this object a percentage closer to the target
    /// each time this function is called.
    /// Will move it over time if put in update.
    /// </summary>
    public void Move()
    {
        //transform.position = (target.position - transform.position) * percentage;
        transform.position += (target.position - transform.position) * percentage;
    }
}
