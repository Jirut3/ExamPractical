using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


    public class SpinMovement : MonoBehaviour
    {
        [SerializeField]
        private float _angularSpeed = 1.0f;
        [SerializeField]
        private Vector3 _axisOfRotation = new Vector3(0f,0,1);
        private Transform _objTransformComponent;

        void Start()
        {
            _objTransformComponent = this.gameObject.GetComponent<Transform>();  
        }

        void Update()
        {
            _objTransformComponent.Rotate(_axisOfRotation, _angularSpeed); 
        }
    }
