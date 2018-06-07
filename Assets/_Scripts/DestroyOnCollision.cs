// Written by Aaron Goss

using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    enum DestructionTarget { Undefined, ThisObject, OtherObject, BothCollisionObjects }
    [SerializeField] DestructionTarget destructionTarget = DestructionTarget.Undefined;

    private void OnCollisionEnter(Collision collision)
    {
        DestroyTargetObject(collision.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        DestroyTargetObject(other.gameObject);
    }

    public void DestroyTargetObject(GameObject target)
    {
        if (destructionTarget == DestructionTarget.ThisObject)
        {
            Destroy(gameObject);
        }
        else if (destructionTarget == DestructionTarget.OtherObject)
        {
            Destroy(target);
        }
        else if(destructionTarget == DestructionTarget.BothCollisionObjects)
        {
            Destroy(target);
            Destroy(gameObject);
        }
    }
}
