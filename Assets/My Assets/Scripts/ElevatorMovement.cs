using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMovement : MonoBehaviour
{
    private bool _isMovingUp = true;
    private Vector3 _startPosition;
    private float _topY = 5;
    private float _moveSpeed = 2f;

    void Start()
    {
        _startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float movement = _moveSpeed * Time.deltaTime;

        if (_isMovingUp)
        {
            transform.position += new Vector3(0f, movement, 0f);

            _isMovingUp = !(transform.position.y >= _startPosition.y + _topY);
        }
        else
        {
            transform.position -= new Vector3(0, movement, 0);
            _isMovingUp = transform.position.y <= _startPosition.y;
        }
    }
}
