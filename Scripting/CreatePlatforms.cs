using System;
using System.Collections.Generic;
using final_project.Casting;
using final_project.Scripting;

namespace final_project.Scripting
{
    /// <summary>
    /// An action to create more platforms.
    /// </summary>
    
    public class CreatePlatforms : Action
    {
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            if (cast["platform"].Count < Constants.ON_SCREEN_PLATFORM_LIMIT)
            {
                
                Platform platform = new Platform();
                cast["platform"].Add(platform);
                
            }
        }
    }
}