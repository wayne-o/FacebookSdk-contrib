using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facebook.Api.Graph
{
    public class GraphInsight
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Period { get; set; }
        public string Description { get; set; }
        public List<KeyValuePair<DateTime, int>> Values { get; set; }

    }
}
