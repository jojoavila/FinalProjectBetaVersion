using System;

namespace final_project.Casting
{
    /// <summary>
    /// Class of platforms.
    /// </summary>
    public class Platform : Actor
    {
        Random randNum = new Random();
        public Platform()
        {
            SetWidth(48);
            SetHeight(24);
            
            int x = randNum.Next(25, Constants.MAX_X - 50);
            int y = 0;
            
            
            _position = new Point(x, y);
            _velocity = new Point(0, Constants.PLATFOM_SPEED);          
        }
    }
}