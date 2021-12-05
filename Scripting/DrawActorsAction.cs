using System;
using System.Collections.Generic;
using final_project.Casting;
using final_project.Services;

namespace final_project.Scripting
{
    /// <summary>
    /// An action to draw all of the actors in the game.
    /// </summary>
    public class DrawActorsAction : Action
    {
        private OutputService _outputService;

        public DrawActorsAction(OutputService outputService)
        {
            _outputService = outputService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            _outputService.StartDrawing();

            foreach (List<Actor> group in cast.Values)
            {
                _outputService.DrawActors(group);
            }

            _outputService.EndDrawing();
        }

    }
}