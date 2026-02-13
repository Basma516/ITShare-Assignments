using System;
using System.Collections.Generic;
using System.Text;

namespace C_Session04
{
    public interface IMovable
    {
        void MoveUp();
        void MoveDown();
        void MoveLeft();
        void MoveRight();
    }
    public class MovablePoint : IMovable
    {
        internal int x;
        internal int y;
        internal int xSpeed;
        internal int ySpeed;
        public MovablePoint(int x, int y, int xSpeed, int ySpeed)
        {
            this.x = x;
            this.y = y;
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }
        public void MoveUp()
        {
            y += ySpeed;
        }
        public void MoveDown()
        {
            y -= ySpeed;
        }
        public void MoveLeft()
        {
            x -= xSpeed;
        }
        public void MoveRight()
        {
            x += xSpeed;
        }
        public override string ToString()
        {
            return "MovablePoint: (" + x + "," + y + ") speed=(" + xSpeed + "," + ySpeed + ")";
        }
    }
}
