using System;

namespace DotvvmWeb.Views.Docs.Controls.businesspack.DateTimeRangePicker.sample6
{
    public class ViewModel
    {
        public DateTime StartDate { get; set; } = DateTime.Now.AddDays(-1);
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);
        public int DateSelectionsCount { get; set; }

        public void SelectionCompleted()
        {
            DateSelectionsCount++;
        }
    }
}