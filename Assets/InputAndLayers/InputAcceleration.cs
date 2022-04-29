using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputAcceleration : MonoBehaviour
{
    const float updateSpeed = 30.0f;

    float acceleroMeterUpdateInterval = 1.0f / updateSpeed;

    float lowPassKernelWidthInSeconds = 1.0f;

    float lowPassFilterFactor = 0;
    Vector3 lowPassValue = Vector3.zero;

    void Start(){
        lowPassFilterFactor = acceleroMeterUpdateInterval / lowPassKernelWidthInSeconds;
        lowPassValue = Input.acceleration;
    }

    Vector3 filterAccelValue(bool smooth){
        if(smooth)
            lowPassValue = Vector3.Lerp(lowPassValue, Input.acceleration, lowPassFilterFactor);
        else
            lowPassValue = Input.acceleration;

        return lowPassValue;
    }

    Vector3 preciseAccelValue(){
        Vector3 accelResult = Vector3.zero;
        for(int i = 0; i < Input.accelerationEventCount; ++i){
            accelResult = accelResult + (Input.GetAccelerationEvent(i).acceleration *
                    Input.GetAccelerationEvent(i).deltaTime);
        }

        return accelResult;
    }
}
