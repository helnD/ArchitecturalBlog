using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain
{
    public class Knowledge
    {
        public Knowledge(string title, string description, string type,
            IEnumerable<Knowledge> associatedKnowledge)
        {
            Title = title;
            Description = description;
            Type = type;
            AssociatedKnowledge = associatedKnowledge;
        }

        public string Title { get; }
        public string Description { get; }
        public string Type { get; }
        public IEnumerable<Knowledge> AssociatedKnowledge { get; }
        
    }
}