using System.Collections.Generic;
using final_project.Casting;
using final_project.Services;

namespace final_project.Scripting
{
    /// <summary>
    /// An action, so the hero bounces or jump when collides with a platform.
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();
        AudioService _audioService = new AudioService();
        public HandleCollisionsAction(PhysicsService physicsService)
        {
            _physicsService = physicsService;
        } 

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> heroList = cast["hero"];
            List<Actor> platformList = cast["platform"];
            //Actor ground = cast["ground"][0];

            foreach (Actor actor in heroList)
            {
                Hero hero = (Hero)actor;
                int x = hero.GetX();
                int y = hero.GetY();
                //int x_ground = ground.GetX();
                //int y_ground = ground.GetY();
                
                // if (_physicsService.IsCollision(ground, hero))
                // {
                //     hero.BounceVertical();
                // }
                // hero.DownwardDirectionByVariable();                
            
                foreach (Actor platform in platformList)
                {
                                     
                    if (_physicsService.IsCollision(platform, hero))
                    {
                        hero.BounceVertical();
                    }
                    hero.DownwardDirection();                
                }
            }
        }
    }
}