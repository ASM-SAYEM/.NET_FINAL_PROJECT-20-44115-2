using DAL.EF;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class Repo
    {
        protected FeedbackContext db;
        internal Repo()
        {
            db = new FeedbackContext();
        }
    }
}
