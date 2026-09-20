using PHY_LIB.Maths.vec;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace PHY_LIB.Maths.matrix
{
    public struct mat4<T> where T : INumber<T>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public mat4(T a11, T a12, T a13, T a14, T a21, T a22, T a23, T a24, T a31, T a32, T a33, T a34, T a41, T a42, T a43, T a44)
        {
            this.a11 = a11; this.a12 = a12; this.a13 = a13; this.a14 = a14;
            this.a21 = a21; this.a22 = a22; this.a23 = a23; this.a24 = a24;
            this.a31 = a31; this.a32 = a32; this.a33 = a33; this.a34 = a34;
            this.a41 = a41; this.a42 = a42; this.a43 = a43; this.a44 = a44;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public mat4(T a11, T a22, T a33, T a44)
        {
            this.a11 = a11;
            this.a22 = a22;
            this.a33 = a33;
            this.a44 = a44;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public mat4(T multiple)
        {
            a11 = multiple;
            a22 = multiple;
            a33 = multiple;
            a44 = multiple;
        }

        T a11, a12, a13, a14;
        T a21, a22, a23, a24;
        T a31, a32, a33, a34;
        T a41, a42, a43, a44;

        public T A11
        {
            get
            { return a11; }
            init;
        }
        public T A12
        {
            get
            { return a12; }
            init;
        }
        public T A13
        {
            get
            {
                return a13;
            }
            init;
        }
        public T A14
        {
            get
            {
                return a14;
            }
            init;
        }
        public T A21
        {
            get
            {
                return a21;
            }
            init;
        }
        public T A22
        {
            get
            {
                return a22;
            }
            init;
        }
        public T A23
        {
            get
            {
                return a23;
            }
            init;
        }
        public T A24
        {
            get
            {
                return a24;
            }
            init;
        }
        public T A31
        {
            get
            {
                return a31;
            }
            init;
        }
        public T A32
        {
            get
            {
                return a32;
            }
            init;
        }
        public T A33
        {
            get
            {
                return a33;
            }
            init;
        }
        public T A34
        {
            get
            {
                return a34;
            }
            init;
        }
        public T A41
        {
            get
            {
                return a41;
            }
            init;
        }
        public T A42
        {
            get
            {
                return a42;
            }
            init;
        }
        public T A43
        {
            get
            {
                return a43;
            }
            init;
        }
        public T A44
        {
            get
            {
                return a44;
            }
            init;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static mat4<T> Scale(mat4<T> m, vec3<T> v)
        {
            return new mat4<T>(
                    m.a11 * v.X, m.a12 * v.Y, m.a13 * v.Z, m.a14,
        m.a21 * v.X, m.a22 * v.Y, m.a23 * v.Z, m.a24,
        m.a31 * v.X, m.a32 * v.Y, m.a33 * v.Z, m.a34,
        m.a41 * v.X, m.a42 * v.Y, m.a43 * v.Z, m.a44
                      );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static mat4<T> Translate(mat4<T> m, vec3<T> v)
        {
            T one = (T)T.CreateTruncating(1);
            return new mat4<T>(
        m.a11, m.a12, m.a13, (m.a11 * v.X) + (m.a12 * v.Y) + (m.a13 * v.Z) + (m.a14 * one),
        m.a21, m.a22, m.a23, (m.a21 * v.X) + (m.a22 * v.Y) + (m.a23 * v.Z) + (m.a24 * one),
        m.a31, m.a32, m.a33, (m.a31 * v.X) + (m.a32 * v.Y) + (m.a33 * v.Z) + (m.a34 * one),
        m.a41, m.a42, m.a43, (m.a41 * v.X) + (m.a42 * v.Y) + (m.a43 * v.Z) + (m.a44 * one)

           );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static mat4<T> RotationX(float radians)
        {
            T c = (T)T.CreateTruncating(Math.Cos(radians));
            T s = (T)T.CreateTruncating(Math.Sin(radians));
            T zero = (T)T.CreateTruncating(0);
            T one = (T)T.CreateTruncating(1);

            return new mat4<T>(
                one, zero, zero, zero,
                zero, c, -s, zero,
                zero, s, c, zero,
                zero, zero, zero, one
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static mat4<T> RotationY(float radians)
        {
            T c = (T)T.CreateTruncating(Math.Cos(radians));
            T s = (T)T.CreateTruncating(Math.Sin(radians));
            T zero = (T)T.CreateTruncating(0);
            T one = (T)T.CreateTruncating(1);

            return new mat4<T>(
                c, zero, s, zero,
                zero, one, zero, zero,
                -s, zero, c, zero,
                zero, zero, zero, one
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static mat4<T> RotationZ(float radians)
        {
            T c = T.CreateTruncating(Math.Cos(radians));
            T s = (T)T.CreateTruncating(Math.Sin(radians));
            T zero = (T)T.CreateTruncating(0);
            T one = (T)T.CreateTruncating(1);

            return new mat4<T>(
                c, -s, zero, zero,
                s, c, zero, zero,
                zero, zero, one, zero,
                zero, zero, zero, one
            );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static mat4<T> Perspective(float rFov, float aspect, float near, float far)
        {
            T zero = T.CreateTruncating(0);

            T tanHalfFOV = T.CreateTruncating(Math.Tan(rFov / 2.0));
            T f = T.CreateTruncating(1.0) / tanHalfFOV;

            T rangeInv = T.CreateTruncating(1.0 / (near - far));

            return new mat4<T>(
                f / T.CreateTruncating(aspect), zero, zero, zero,
                zero, f, zero, zero,
                zero, zero, T.CreateTruncating(far + near) * rangeInv, T.CreateTruncating(2.0 * far * near) * rangeInv,
                zero, zero, T.CreateTruncating(-1.0f), zero);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static mat4<T> operator +(mat4<T> m, mat4<T> m2)
        {
            return new mat4<T>(
                m.a11 + m2.a11, m.a12 + m2.a12, m.a13 + m2.a13, m.a14 + m2.a14,
                m.a21 + m2.a21, m.a22 + m2.a22, m.a23 + m2.a23, m.a24 + m2.a24,
                m.a31 + m2.a31, m.a32 + m2.a32, m.a33 + m2.a33, m.a34 + m2.a34,
                m.a41 + m2.a41, m.a42 + m2.a42, m.a43 + m2.a43, m.a44 + m2.a44
                );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static mat4<T> operator -(mat4<T> m, mat4<T> m2)
        {
            return new mat4<T>(
              m.a11 - m2.a11, m.a12 - m2.a12, m.a13 - m2.a13, m.a14 - m2.a14,
              m.a21 - m2.a21, m.a22 - m2.a22, m.a23 - m2.a23, m.a24 - m2.a24,
              m.a31 - m2.a31, m.a32 - m2.a32, m.a33 - m2.a33, m.a34 - m2.a34,
              m.a41 - m2.a41, m.a42 - m2.a42, m.a43 - m2.a43, m.a44 - m2.a44
              );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static mat4<T> operator *(T lambda, mat4<T> m)
        {
            return new(
                m.a11 * lambda, m.a12 * lambda, m.a13 * lambda, m.a14 * lambda,
                m.a21 * lambda, m.a22 * lambda, m.a23 * lambda, m.a24 * lambda,
                m.a31 * lambda, m.a32 * lambda, m.a33 * lambda, m.a34 * lambda,
                m.a41 * lambda, m.a42 * lambda, m.a43 * lambda, m.a44 * lambda
                );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static mat4<T> operator /(T lambda, mat4<T> m)
        {
            return new(
                       m.a11 / lambda, m.a12 / lambda, m.a13 / lambda, m.a14 / lambda,
                       m.a21 / lambda, m.a22 / lambda, m.a23 / lambda, m.a24 / lambda,
                       m.a31 / lambda, m.a32 / lambda, m.a33 / lambda, m.a34 / lambda,
                       m.a41 / lambda, m.a42 / lambda, m.a43 / lambda, m.a44 / lambda
                       );
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static mat4<T> operator *(mat4<T> m, mat4<T> m2)
        {
            return new(
                 (m.a11 * m2.a11) + (m.a12 * m2.a21) + (m.a13 * m2.a31) + (m.a14 * m2.a41),
                   (m.a11 * m2.a12) + (m.a12 * m2.a22) + (m.a13 * m2.a32) + (m.a14 * m2.a42),
                    (m.a11 * m2.a13) + (m.a12 * m2.a23) + (m.a13 * m2.a33) + (m.a14 * m2.a43),
                      (m.a11 * m2.a14) + (m.a12 * m2.a24) + (m.a13 * m2.a34) + (m.a14 * m2.a44),

                      (m.a21 * m2.a11) + (m.a22 * m2.a21) + (m.a23 * m2.a31) + (m.a24 * m2.a41),
                      (m.a21 * m2.a12) + (m.a22 * m2.a22) + (m.a23 * m2.a32) + (m.a24 * m2.a42),
                      (m.a21 * m2.a13) + (m.a22 * m2.a23) + (m.a23 * m2.a33) + (m.a24 * m2.a43),
                      (m.a21 * m2.a14) + (m.a22 * m2.a24) + (m.a23 * m2.a34) + (m.a24 * m2.a44),

                          (m.a31 * m2.a11) + (m.a32 * m2.a21) + (m.a33 * m2.a31) + (m.a34 * m2.a41),
                      (m.a31 * m2.a12) + (m.a32 * m2.a22) + (m.a33 * m2.a32) + (m.a34 * m2.a42),
                      (m.a31 * m2.a13) + (m.a32 * m2.a23) + (m.a33 * m2.a33) + (m.a34 * m2.a43),
                      (m.a31 * m2.a14) + (m.a32 * m2.a24) + (m.a33 * m2.a34) + (m.a34 * m2.a44),

                          (m.a41 * m2.a11) + (m.a42 * m2.a21) + (m.a43 * m2.a31) + (m.a44 * m2.a41),
                      (m.a41 * m2.a12) + (m.a42 * m2.a22) + (m.a43 * m2.a32) + (m.a44 * m2.a42),
                      (m.a41 * m2.a13) + (m.a42 * m2.a23) + (m.a43 * m2.a33) + (m.a44 * m2.a43),
                      (m.a41 * m2.a14) + (m.a42 * m2.a24) + (m.a43 * m2.a34) + (m.a44 * m2.a44)
                );
        }


    }
}
