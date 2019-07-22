using System;
using System.Collections.Generic;
using System.Text;

namespace MyMasterDetailPage.Pages.Menu
{
    public class MasterMenuItems
    {
        public string Text { get; set; }
        public string Detail { get; set; }
        public string ImagePath { get; set; }
        public Type TargetType { get; set; }
    }
}
