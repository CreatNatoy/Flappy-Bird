using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdIntilialize : MonoBehaviour
{
    private void Awake()
    {
       // MobileAds.Initialize(InitializationStatus => { });
        MobileAds.Initialize(initStatus => { });
    }
}
