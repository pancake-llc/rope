using Unity.Mathematics;
using UnityEngine;

namespace Pancake.Rope
{
    public struct VerletNode
    {
        public float2 position;
        public float2 oldPosition;
        public float2 acceleration;
        public float friction;

        public VerletNode(Vector2 position, float friction = 1f)
        {
            this.position = position;
            this.oldPosition = position;
            this.acceleration = float2.zero;
            this.friction = friction;
        }
    }

    public struct Constraint
    {
        public bool enabled;
        public float2 position;
    }

    public struct CollisionInfo
    {
        public int id;
        public EColliderType colliderType;
        public float2 colliderSize;
        public float2 position;
        public float2 scale;
        public float4x4 wtl;
        public float4x4 ltw;
        public int numCollisions;
    }
    
    public enum EColliderType
    {
        None = -1,
        Circle = 0,
        Box = 1
    }
}