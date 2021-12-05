using System;
using System.Collections.Generic;
using final_project.Casting;

namespace final_project
{
    public abstract class Action
    {
        public abstract void Execute(Dictionary<string, List<Actor>> cast);
    }
}