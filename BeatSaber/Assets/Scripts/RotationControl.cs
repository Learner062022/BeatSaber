using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class RotationControl : MonoBehaviour
{
    int[] _rotations = new int[4] { 0, 90, 180, 360 };
    int _index;

    void Start()
    {
        _index = Random.Range(0, _rotations.Length);
       
        while (_rotations[_index] == gameObject.transform.eulerAngles.z)
        {
            _index = Random.Range(0, _rotations.Length);
        }

        float newAngle = _rotations[_index];
        gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y, newAngle);
    }
}
