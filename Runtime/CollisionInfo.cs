using UnityEngine;

namespace Pancake.Rope
{
    public class CollisionInfo
    {
        public int id;
        public EColliderType colliderType;
        public Vector2 colliderSize;
        public Vector2 position;
        public Vector2 scale;
        public Matrix4x4 wtl;
        public Matrix4x4 ltw;
        public int numCollisions;
        public int[] collidingNodes;

        public CollisionInfo(int maxCollisons)
        {
            this.id = -1;
            this.colliderType = EColliderType.None;
            this.colliderSize = Vector2.zero;
            this.position = Vector2.zero;
            this.scale = Vector2.zero;
            this.wtl = Matrix4x4.zero;
            this.ltw = Matrix4x4.zero;
            this.numCollisions = 0;
            this.collidingNodes = new int [maxCollisons];
        }
    }
}