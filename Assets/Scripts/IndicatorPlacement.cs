using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class IndicatorPlacement : MonoBehaviour
{
   public GameObject _ringIndicator;
   public ARRaycastManager _raycastManager;
   [HideInInspector] public Vector3 hitPosition;

   Vector2 _screenCenter;

    void Start() {

       _screenCenter = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);

    }
    // Update is called once per frame
    void Update()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();

        if (_raycastManager.Raycast(_screenCenter, hits, TrackableType.Planes))
        {
            if (!_ringIndicator.activeSelf)
            {
                _ringIndicator.SetActive(true);
            }

            Pose hitPose = hits[0].pose;

            _ringIndicator.transform.position = hitPose.position;
        }
        else
        {
            if (_ringIndicator.activeSelf)
            {
                _ringIndicator.SetActive(false);
            }
        }
    }

    public void PlaceModel(GameObject obj)
    {
        obj.transform.position = _ringIndicator.transform.position;
        obj.SetActive(true);
    }
}
