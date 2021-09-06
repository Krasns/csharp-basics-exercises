using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Movies
    {
        string _title;
        string _studio;
        string _rating;
        public Movies(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }
        public Movies(string title, string studio)
        {
            _title = title;
            _studio = studio;
        }
        public List<string> GetPG(List<string> pgIn)
        {
            List<string> pgOut = new List<string>();
            for (int i = 0; i < pgIn.Count; i++)
            {
                if (pgIn[i] == "PG")
                {
                    pgOut[i] += pgIn[i];
                }
            }
            return pgOut;
        }
    }
}
