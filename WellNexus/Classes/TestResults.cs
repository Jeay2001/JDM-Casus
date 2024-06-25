﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellNexus
{
    internal class TestResults
    {

        // variables

        public int Id { get; set; }
        public DateTime TestDate { get; set; }
        public string ResultData { get; set; }
        public bool verified { get; set; }

        // constructor

        public TestResults(int id, DateTime TestDate, string ResultData)
        {
            this.Id = id;
            this.TestDate = TestDate;
            this.ResultData = ResultData;
            this.verified = false;
        }

        // Methods

    }
}
