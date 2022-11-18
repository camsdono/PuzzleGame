using UnityEngine;

public class BasicRigidBodyPush : MonoBehaviour
{
	[Range(0.5f, 5f)] public float strength = 1.1f;

	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
		PushRigidBodies(hit);
	}

	private void PushRigidBodies(ControllerColliderHit hit)
	{
		Rigidbody rigidbody = hit.collider.attachedRigidbody;

		if (rigidbody != null)
		{
			Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
			forceDirection.y = 0;
			forceDirection.Normalize();
			
			rigidbody.AddForceAtPosition(forceDirection * strength, transform.position, ForceMode.Impulse);
		}
	}
}