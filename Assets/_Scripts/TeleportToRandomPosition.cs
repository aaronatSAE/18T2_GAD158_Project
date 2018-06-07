// Written by Aaron Goss

using UnityEngine;

public class TeleportToRandomPosition : MonoBehaviour
{
    /// <summary>
    /// Makes this object teleport.
    /// </summary>
    [SerializeField] KeyCode activationKey = KeyCode.Space;

    /// <summary>
    /// The maximum distance this object can teleport.
    /// </summary>
    [SerializeField] Vector3 teleportRange = Vector3.one * 5f;

    [SerializeField] bool anchored = true;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(activationKey))
        {
            Teleport();
        }
    }

    private void OnDrawGizmosSelected()
    {   
        // Draw a wire rectangular prism to show the teleportation range.
        if (anchored)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(Vector3.zero, teleportRange);
            Gizmos.color = Color.white;
            Gizmos.DrawLine(transform.position, Vector3.zero);
            Gizmos.color = Color.cyan;
            for (int x = -1; x < 2; x++)
            {
                for(int z = -1; z < 2; z++)
                {
                    Gizmos.DrawLine(Vector3.zero, new Vector3(x * teleportRange.x/2f, 0, z * teleportRange.z/2f));
                }
            }
        }
        else
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(transform.position, teleportRange);
            Gizmos.color = Color.cyan;
            for (int x = -1; x < 2; x++)
            {
                for (int z = -1; z < 2; z++)
                {
                    Gizmos.DrawLine(transform.position, transform.position + new Vector3(x * teleportRange.x/2f, 0, z * teleportRange.z/2f));
                }
            }
        }
    }

    /// <summary>
    /// Instantly moves this object to a new, random location inside the teleportation range.
    /// </summary>
    public void Teleport()
    {
        if (anchored)
        {
            Vector3 destination = new Vector3(
                Random.Range(-teleportRange.x, teleportRange.x)/2f,
                Random.Range(-teleportRange.y, teleportRange.y)/2f,
                Random.Range(-teleportRange.z, teleportRange.z)/2f
                );
            transform.position = destination;
        }
        else
        {
            Vector3 destination = new Vector3(
                Random.Range(-teleportRange.x, teleportRange.x)/2f,
                Random.Range(-teleportRange.y, teleportRange.y)/2f,
                Random.Range(-teleportRange.z, teleportRange.z)/2f
                );
            transform.position += destination;
        }
    }
}
