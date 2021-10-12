using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        // If rigidbody or the box collider is there, this function would be called.

        Debug.Log("We hit ->" + collision.collider.name);

        if(collision.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle, Aveek!");
            movement.enabled = false;
        }
    }

}
