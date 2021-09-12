using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalMillionare.Models
{
    public class StoredData
    {
        
        public Dictionary<string, Dictionary<string, byte>> StoredQuestions { get; set; }
        public Dictionary<string, byte> StoredAnswers { get; set; } = new Dictionary<string, byte>() {{"", 0 }};
        public int Step { get; set; } = 0;
        public int CurId { get; set; } = 1;
        public string CurrentAnswer { get; set; }
        public List<string> Score { get; set; } = new List<string> { "1000", "10000", "25000", "50000", "125000", "200000", "300000", "500000", "750000", "1000000" };

    }
}