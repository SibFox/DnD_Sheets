using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DnDSheets.Common
{
    public static class Manager
    {
        public static Frame MainFrame { get; set; }
        public static string MainFrame_PageName { get; set; }
        public static Frame FrameContainer_First { get; set; }
        public static string FrameContainer_First_PageName { get; set; }

        public static void HandleMainFramePageChange(Page page)
        {
            if (MainFrame_PageName != page.Name) 
            {
                MainFrame.Navigate(page);
                MainFrame_PageName = page.Name;
            }
        }
    }
}
