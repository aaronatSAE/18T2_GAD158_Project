// Written by Aaron Goss

using UnityEngine;

public class RotateOverTime : MonoBehaviour
{
    /// <summary>
    /// The amount of degrees this object will rotate per second
    /// on each axis (x, y, z).
    /// </summary>
    [SerializeField] Vector3 degreesPerSecond = Vector3.zero;

    /// <summary>
    /// Toggle this to reverse the rotation direction.
    /// </summary>
    [SerializeField] bool rotatingClockwise = true;

    // Update is called once per frame
    private void Update()
    {
        Rotate();
    }

    /// <summary>
    /// Rotates this object over time.
    /// </summary>
    public void Rotate()
    {
        if (rotatingClockwise)
        {
            transform.Rotate(degreesPerSecond * Time.deltaTime);
        }
        else
        {
            transform.Rotate(-degreesPerSecond * Time.deltaTime);
        }
    }
}
