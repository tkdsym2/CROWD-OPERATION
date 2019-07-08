using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace MoveFunction
{
    public static class UserCursorFunc
    {
        public static Vector3 GenerateRandomPosition(float _w, float _h)
        {
            float rx = UnityEngine.Random.Range(0, _w);
            float ry = UnityEngine.Random.Range(0, _h);
            Vector3 randomPos = new Vector3(rx, ry, 0);
            Vector3 converted = Camera.main.ScreenToWorldPoint(randomPos);
            Debug.Log(converted.x + " , " + converted.y);
            return converted;
        }

        private static Vector3 CursorRange(Vector3 _pos)
        {
            int width = Screen.width;
            int height = Screen.height;
            Vector3 screenPoint = Camera.main.WorldToScreenPoint(_pos);
            if (screenPoint.x < 0)
            {
                screenPoint.x = width;
            }
            else if (screenPoint.x > width)
            {
                screenPoint.x = 0;
            }

            if (screenPoint.y < 0)
            {
                screenPoint.y = height;
            }
            else if (screenPoint.y > height)
            {
                screenPoint.y = 0;
            }

            _pos = Camera.main.ScreenToWorldPoint(screenPoint);
            return _pos;
        }

        public static IEnumerator DelayCursor(float _waitTime, Action _action)
        {
            yield return new WaitForSeconds(_waitTime);
            _action();
        }

        public static void MoveCursor(GameObject _gameObject, Vector3 _direction, float _cdr)
        {
            _gameObject.transform.position = CursorRange(_gameObject.transform.position);
            _gameObject.transform.position += _cdr * _direction;
        }
    }

    public static class DummyCursorFunc
    {
        private static Vector3 CursorRange(Vector3 _pos)
        {
            int width = Screen.width;
            int height = Screen.height;
            Vector3 screenPoint = Camera.main.WorldToScreenPoint(_pos);
            if (screenPoint.x < 0)
            {
                screenPoint.x = width;
            }
            else if (screenPoint.x > width)
            {
                screenPoint.x = 0;
            }

            if (screenPoint.y < 0)
            {
                screenPoint.y = height;
            }
            else if (screenPoint.y > height)
            {
                screenPoint.y = 0;
            }

            _pos = Camera.main.ScreenToWorldPoint(screenPoint);
            return _pos;
        }

        public static IEnumerator DelayCursor(float _waitTime, Action _action)
        {
            yield return new WaitForSeconds(_waitTime);
            _action();
        }

        private static Vector3 CalcDirection(float _angle, Vector3 _direction)
        {
            float _drangle = _angle;
            float moveRad = (float)(System.Math.PI * _drangle / 180.0);
            float rad = (float)(System.Math.Atan2(_direction.y, _direction.x) + moveRad);
            float moveDist = _direction.magnitude;
            float relativeX = (float)(moveDist * System.Math.Cos(rad));
            float relativeY = (float)(moveDist * System.Math.Sin(rad));
            Vector3 addDirection = new Vector3(relativeX, relativeY, 0);
            return addDirection;
        }

        // args:
        //      _gameObject: generated DummyCursor
        //      _direction: mouse axis
        public static void MoveDummyCursor(GameObject _gameObject, Vector3 _direction, float _cdr)
        {
            _gameObject.transform.position = CursorRange(_gameObject.transform.position);
            _gameObject.transform.position += _cdr * CalcDirection(_gameObject.transform.position.z, _direction);
        }
    }
}
