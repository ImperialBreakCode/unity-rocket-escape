using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement1 : MonoBehaviour
{
    private bool _isMovingLeft = true;
    private Vector3 _startPosition;
    private float _left = 3;
    private float _moveSpeed = 2f;

    void Start()
    {
        _startPosition = transform.position;
        _startPosition.z -= _left;
    }

    // Update is called once per frame
    void Update()
    {
        float movement = _moveSpeed * Time.deltaTime;

        if (_isMovingLeft)
        {
            transform.position += new Vector3(0f, 0f, movement);

            _isMovingLeft = !(transform.position.z >= _startPosition.z + _left);
        }
        else
        {
            transform.position -= new Vector3(0f, 0f, movement);
            _isMovingLeft = transform.position.z <= _startPosition.z;
        }
    }
}
