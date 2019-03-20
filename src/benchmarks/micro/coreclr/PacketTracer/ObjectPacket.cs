// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.Intrinsics;

namespace HardwareIntrinsics.RayTracer
{
    internal abstract class ObjectPacket256
    {
        public Surface Surface { get; }
        public abstract Vector256<float> Intersect(RayPacket256 rayPacket256);
        public abstract VectorPacket256 Normals(VectorPacket256 pos);

        public ObjectPacket256(Surface surface)
        {
            Surface = surface;
        }
    }
}