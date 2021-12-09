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
        private bool canBounce = true;
        public HandleCollisionsAction(PhysicsService physicsService)
        {
            _physicsService = physicsService;
        } 

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> heroList = cast["hero"];
            List<Actor> platformList = cast["platform"];
            Actor scoreBoard = cast["scoreBoard"][0];
            //Actor ground = cast["ground"][0];

            foreach (Actor actor in heroList)
            {
                ScoreBoard _scoreBoard = (ScoreBoard)scoreBoard;
                Hero hero = (Hero)actor;
                int x = hero.GetX();
                int y = hero.GetY();
                               
            
                foreach (Actor platform in platformList)
                {
                                     
                    if (_physicsService.IsCollision(platform, hero) && canBounce)
                    {
                        hero.BounceVertical();
                        _audioService.PlaySound(Constants.SOUND_BOUNCE);
                        _scoreBoard.AddPoints(5);

                    }
                    hero.DownwardDirection();               
                }
            }
        }
    }
}