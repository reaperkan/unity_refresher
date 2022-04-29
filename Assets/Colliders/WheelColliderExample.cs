using UnityEngine;
// -> MeshColliders will only collide if we have convex check to true
public class WheelColliderExample : MonoBehaviour
{
    [Tooltip ("Weight of the wheel in kgs")]
    public float mass=2;

    [Tooltip ("Radius of the wheel collider in meters")]
    public float radius=2;

    [Tooltip ("Adjusts how responsive the wheels are to torque")]
    public float wheelDampingRate= 10;

    [Tooltip ("Total travel distance in meters that the wheel can travel")]
    public float suspensionDistance = 2;

    [Tooltip ("Where the force from the suspension should be applied to the parent rigidboy")]
    public float forceAppPointDistance;

    [Tooltip ("Wheel center position")]
    public Vector3 center;
    void Start()
    {
        WheelCollider wheelCollider = this.gameObject.AddComponent<WheelCollider>();
        wheelCollider.mass = mass;
        wheelCollider.radius = radius;
        wheelCollider.wheelDampingRate = wheelDampingRate;
        wheelCollider.suspensionDistance = suspensionDistance;
        wheelCollider.forceAppPointDistance = forceAppPointDistance;
        wheelCollider.center = center;
        // Spring Constance,K, F = K * Distance 
        // A good starting point is (Mass / Wheels) * 75

        // Damper
        // Equivalent of shocke absorber in car , higher rates = stifer, lower rates = softer

        // Sideways Friction Settings
        // Extremum Slip = Max amount in m/s the wheel can slip before it loses traction
        // Extremum Value = Maxx amount of friction applied in each wheel
    }
}
