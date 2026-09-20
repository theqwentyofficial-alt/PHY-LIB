using System.Numerics;
using System.Runtime.CompilerServices;
namespace PHY_LIB.Maths.vec
{
    public struct vec3<T> where T : INumber<T>
    {
        public T X { get; init; }
        public T Y { get; init; }
        public T Z { get; init; }
        public vec3()
        {
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public vec3(T x, T y, T z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T GetDistance(vec3<T> v, vec3<T> v2)
        {
            return T.CreateTruncating(Math.Sqrt(double.CreateTruncating(((v2.X - v.X) * (v2.X - v.X)) + ((v2.Y - v.Y) * (v2.Y - v.Y)) + ((v2.Z - v.Z) * (v2.Z - v.Z)))));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T GetDistance(vec3<T> v)
        {
            return T.CreateTruncating(Math.Sqrt(double.CreateTruncating((v.X * v.X) + (v.Y * v.Y) + (v.Z * v.Z))));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToRadians(T degree)
        {
            return degree * T.CreateTruncating(Math.PI / 180.0);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToDegree(T radians)
        {
            return radians * T.CreateTruncating(180.0 / Math.PI);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static vec3<T> Normalize(vec3<T> v)
        {
            return new vec3<T>(v.X / GetDistance(v), v.Y / GetDistance(v), v.Z / GetDistance(v));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Radius(vec3<T> v, vec3<T> v2)
        {
            return DotProduct(v, v2) / (GetDistance(v) * GetDistance(v2));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T GetDegrees(vec3<T> v, vec3<T> v2)
        {
            return ToDegree(T.CreateTruncating(Math.Acos(double.CreateTruncating(DotProduct(v, v2)))));
        }
        public static T GetDegreesUnnormalized(vec3<T> v, vec3<T> v2)
        {
            return ToDegree(T.CreateTruncating(Math.Acos(double.CreateTruncating(Radius(v, v2)))));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T DotProduct(vec3<T> v, vec3<T> v2)
        {
            return (v.X * v2.X) + (v.Y * v2.Y) + (v.Z * v2.Z);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T DotProduct(T vLen, T v2Len, T cos)
        {
            return (vLen * v2Len) * cos;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static vec3<T> CrossProduct(vec3<T> v, vec3<T> v2)
        {
            T deltaX = (v.Y * v2.Z) - (v.Z * v2.Y);
            T deltaY = (v.Z * v2.X) - (v.X * v2.Z);
            T deltaZ = (v.X * v2.Y) - (v.Y * v2.X);
            return new vec3<T>(deltaX, deltaY, deltaZ);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPerpendicular(vec3<T> v, vec3<T> v2)
        {
            return DotProduct(v, v2) == T.CreateTruncating(0) || T.CreateTruncating(0) < T.CreateTruncating(0.2);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static vec3<T> operator +(vec3<T> a, vec3<T> b)
        {
            return new vec3<T>(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static vec3<T> operator -(vec3<T> a, vec3<T> b)
        {
            return new(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static vec3<T> operator *(vec3<T> a, vec3<T> b)
        {
            return new vec3<T>(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static vec3<T> operator *(vec3<T> vec, T a)
        {
            return new(vec.X * a, vec.Y * a, vec.Z * a);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static vec3<T> operator /(vec3<T> vec, T a)
        {
            return new(vec.X / a, vec.Y / a, vec.Z / a);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static vec3<T> operator /(vec3<T> a, vec3<T> b)
        {
            return new vec3<T>(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(vec3<T> a, vec3<T> b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(vec3<T> a, vec3<T> b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static vec3<T> operator -(vec3<T> a)
        {
            return new vec3<T>(-a.X, -a.Y, -a.Z);
        }
    }
}
