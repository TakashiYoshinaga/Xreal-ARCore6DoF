using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XrealRootBehavior : MonoBehaviour
{
    private Transform _ARCoreTransform = null;
    private Transform _XrealTransform;

    private void Update()
    {
        if(_ARCoreTransform == null)return;
        transform.position = _ARCoreTransform.position;
    }
    private float YawAngleDegree(Vector3 forward)
    {
        return Mathf.Atan2(forward.x, forward.z) * Mathf.Rad2Deg;
    }
    public void Configure(Transform arcoreTransform, Transform xrealTransform)
    {
        this._ARCoreTransform = arcoreTransform;
        this._XrealTransform = xrealTransform;
        ResetYawAngle();
    }
    public void ResetYawAngle() // Reset Yaw Angle of Nreal Camera(Tentative)
    {
        var arcoreYaw = YawAngleDegree(this._ARCoreTransform.forward);
        var xrealYaw = YawAngleDegree(this._XrealTransform.forward);
        var xrealRootYaw = YawAngleDegree(transform.forward);
        xrealRootYaw += (arcoreYaw - xrealYaw);
        transform.rotation = Quaternion.AngleAxis(xrealRootYaw, Vector3.up);
    }

   
}
