// Written by Aaron Goss

using UnityEngine;

public class MoveOverTime : MonoBehaviour
{
    /// <summary>
    /// The number of metres this object will move per second
    /// on each axis (x, y, z).
    /// </summary>
    [SerializeField] Vector3 distancePerSecond = Vector3.zero;

    /// <summary>
    /// Toggle this to reverse the movement direction.
    /// </summary>
    [SerializeField] bool movingForward = true;

    // Update is called once per frame
    private void Update()
    {
        Move();
    }

    /// <summary>
    /// Moves this object over time.
    /// </summary>
    public void Move()
    {
        if (movingForward)
        {
            transform.position += distancePerSecond * Time.deltaTime;
        }
        else
        {
            transform.position += -distancePerSecond * Time.deltaTime;
        }
    }
}
