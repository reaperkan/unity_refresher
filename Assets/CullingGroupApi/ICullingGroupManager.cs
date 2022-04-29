using System;
using UnityEngine;

// Since CullingGrups are not straightforward , it maybe helpful to encapsulate the bulk of
// logic behind a manager class
public interface ICullingGroupManager{
    int ReserveSphere();
    void ReleaseSphere(int sphereIndex);
    void SetPosition(int sphereIndex, Vector3 position);
    void SetRadius(int sphereIndex, float radius);
    void SetCullingEvent(int sphereIndex, Action<CullingGroupEvent> sphere);
}