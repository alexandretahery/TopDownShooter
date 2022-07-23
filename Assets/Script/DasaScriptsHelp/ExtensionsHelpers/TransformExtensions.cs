using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Extensions
{
    public static class TransformExtensions
    {
        /// <summary>
        /// Rotate the transform to the forward direction with some speed in 2D world
        /// </summary>
        /// <param name="movementDirection"></param>
        /// <param name="rotationSpeed"></param>
        public static void LookAt2D(this Transform transform, Vector3 movementDirection, float rotationSpeed)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

        /// <summary>
        ///  Rotate the transform to the forward direction in 2D world
        /// </summary>
        /// <param name="movementDirection"></param>
        public static void LookAt2D(this Transform transform, Vector3 movementDirection)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = toRotation;
        }
    }
}