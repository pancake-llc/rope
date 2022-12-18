using UnityEngine;

namespace Pancake.Rope
{
    public class VerletNode
    {
        public Vector2 position;
        public Vector2 oldPosition;

        public VerletNode(Vector2 position)
        {
            this.position = position;
            this.oldPosition = position;
        }
    }
}