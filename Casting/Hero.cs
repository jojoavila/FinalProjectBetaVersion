using System;
using final_project.Services;
using Raylib_cs;

namespace final_project.Casting
{
    /// <summary>
    /// Class of the hero.
    /// </summary>
    public class Hero : Actor
    {
        private int _lastCollision;
        
        public Hero()
        {
            SetWidth(15);
            SetHeight(15);
            int x = Constants.MAX_X / 2;
            int y = Constants.MAX_Y / 2;

            Point _position = new Point(x,y);
            SetPosition(_position);
            SetVelocity(new Point(0,5));
            
        }
        
        public void BounceVertical()
        {
            int dx = _velocity.GetX();
            int dy = _velocity.GetY();
            _lastCollision = GetY();
            SetVelocity(new Point(dx,-dy));
        }

        public void DownwardDirection()
        {
            if (GetY()<= _lastCollision - 190)
            {
                SetVelocity(new Point(0,Constants.HERO_SPEED));
            }
        }
    }
}