﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TalentClub
{

    public class MainPageMasterMenuItem
    {
        public MainPageMasterMenuItem()
        {
            TargetType = typeof(MainPageMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }

        public Type TargetType { get; set; }
    }
}