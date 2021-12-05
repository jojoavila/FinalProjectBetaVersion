using System.Collections.Generic;
using final_project.Casting;
using final_project.Services;

namespace final_project.Scripting
{
    /// <summary>
    /// An action to control the horizontal direction of the hero.
    /// </summary>
    public class ControlActorsAction : Action
    {
        InputService _inputService;
        PhysicsService _physicsService;

        public ControlActorsAction(InputService inputService, PhysicsService physicsService)
        {
            _inputService = inputService;
            _physicsService = physicsService;

        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            int x = _inputService.GetDirection();
            
            Actor hero = cast["hero"][0];
            Point vel = hero.GetVelocity();
            int y = vel.GetY();
            hero.SetVelocity(new Point(x,y));            
        }
    }
}