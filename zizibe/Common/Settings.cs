﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zizibe.Common
{
    public class Settings
    {
        public int test { get; set; }

        public Settings(string Name)
        {
            SettingLoad(Name);   
        }

        public void SettingLoad(string Name)
        {

        }
    }
}
