﻿namespace Ficdown.Parser.Model.Story
{
    using System.Collections.Generic;

    public class Scene
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }
        public string RawDescription { get; set; }
        public IDictionary<string, bool> Conditions { get; set; }
        public int LineNumber { get; set; }
        public bool Visited { get; set; }
    }
}
