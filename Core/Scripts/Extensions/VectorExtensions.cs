using UnityEngine;

namespace GameJamStarterKit
{
    /// <summary>
    /// Useful Vector Extensions
    /// </summary>
    public static class VectorExtensions
    {

        /// <summary>
        /// Reproject this Vector3's relative position to <see cref="currentTarget"/> to be relative to <see cref="newTarget"/>
        /// </summary>
        /// <param name="v">this</param>
        /// <param name="currentTarget">current position this Vector3 is relative to</param>
        /// <param name="newTarget">he target position to reproject as relative to</param>
        /// <returns>returns this Vector3 reprojected to be relative to the <see cref="newTarget"/> Vector3 rather than the <see cref="currentTarget"/> Vector3</returns>
        public static Vector3 ReprojectRelativeTo(this Vector3 v, Vector3 currentTarget, Vector3 newTarget)
        {
            var offset = v - currentTarget;
            return newTarget + offset;
        }

        /// <summary>
        /// Reproject this Vector2's relative position to <see cref="currentTarget"/> to be relative to <see cref="newTarget"/>
        /// </summary>
        /// <param name="v">this</param>
        /// <param name="currentTarget">current position this Vector3 is relative to</param>
        /// <param name="newTarget">he target position to reproject as relative to</param>
        /// <returns>returns this Vector2 reprojected to be relative to the <see cref="newTarget"/> Vector2 rather than the <see cref="currentTarget"/> Vector2</returns>
        public static Vector2 ReprojectRelativeTo(this Vector2 v, Vector2 currentTarget, Vector2 newTarget)
        {
            var offset = v - currentTarget;
            return newTarget + offset;
        }
        
        /// <summary>
        /// returns a new Vector3 with the given x
        /// </summary>
        /// <param name="v"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static Vector3 WithX(this Vector3 v, float x)
        {
            v.x = x;
            return v;
        }

        /// <summary>
        /// returns a new Vector3 with the given y
        /// </summary>
        /// <param name="v"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Vector3 WithY(this Vector3 v, float y)
        {
            v.y = y;
            return v;
        }

        /// <summary>
        /// returns a new Vector3 with the given z
        /// </summary>
        /// <param name="v"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static Vector3 WithZ(this Vector3 v, float z)
        {
            v.z = z;
            return v;
        }

        /// <summary>
        /// returns a new Vector2 with the given x
        /// </summary>
        /// <param name="v"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static Vector2 WithX(this Vector2 v, float x)
        {
            v.x = x;
            return v;
        }

        /// <summary>
        /// returns a new Vector2 with the given y
        /// </summary>
        /// <param name="a"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Vector2 WithY(this Vector2 a, float y)
        {
            a.y = y;
            return a;
        }

        /// <summary>
        /// returns this as a new Vector3 with the given z
        /// </summary>
        /// <param name="v"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Vector3 AsVector3WithZ(this Vector2 v, float z)
        {
            return new Vector3(v.x, v.y, z);
        }

        /// <summary>
        /// use this vector to make a euler angle quaternion
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static Quaternion ToQuaternion(this Vector3 v)
        {
            return Quaternion.Euler(v);
        }

        /// <summary>
        /// Gets the direction vector from this vector3 to the other.
        /// </summary>
        /// <param name="v">this vector</param>
        /// <param name="target">target vector</param>
        /// <returns>returns a normalized direction to the target</returns>
        public static Vector3 DirectionTo(this Vector3 v, Vector3 target)
        {
            return (target - v).normalized;
        }

        /// <summary>
        /// Gets the direction vector from this vector3 to the other.
        /// </summary>
        /// <param name="v">this vector</param>
        /// <param name="target">target vector</param>
        /// <returns>returns a normalized direction to the target</returns>
        public static Vector2 DirectionTo(this Vector2 v, Vector2 target)
        {
            return (target - v).normalized;
        }

        /// <summary>
        /// Get the distance to the target
        /// </summary>
        /// <param name="v">this</param>
        /// <param name="target">target to get the distance to</param>
        /// <returns>returns the distance to the target using Vector3.Distance</returns>
        public static float DistanceTo(this Vector3 v, Vector3 target)
        {
            return Vector3.Distance(v, target);
        }

        /// <summary>
        /// Get the distance to the target
        /// </summary>
        /// <param name="v">this</param>
        /// <param name="target">target to get the distance to</param>
        /// <returns>returns the distance to the target using Vector2.Distance</returns>
        public static float DistanceTo(this Vector2 v, Vector2 target)
        {
            return Vector2.Distance(v, target);
        }
    }
}