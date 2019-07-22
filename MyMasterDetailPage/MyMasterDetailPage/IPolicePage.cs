using System;
using System.Collections.Generic;
using System.Text;

namespace MyMasterDetailPage
{
    public interface IPolicePage
    {

        int Id { get; set; }
        string Title { get; set; }
        Type TargetType { get; }
        // string TargetTypeTitle { get; set; }

    }
}
