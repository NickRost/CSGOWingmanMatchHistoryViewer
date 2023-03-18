using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGOWingmanMatchHistoryViewer.Models
{
    internal class GetNextMatchResponse
    {
        public bool Success { get; set; }
        public string Html { get; set; }
        public string ContinueToken { get; set; }
        public string ContinueText { get; set; }

    }
}
