using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCoordinator : MonoBehaviour
{
    [SerializeField]
    XrealRootBehavior _NrealCameraConfig;
    [SerializeField]
    Transform _NrealCameraTransform;
    [SerializeField]
    Transform _ArcoreCameraTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        _NrealCameraConfig.Configure(_ArcoreCameraTransform, _NrealCameraTransform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
