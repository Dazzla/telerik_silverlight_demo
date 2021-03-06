using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace SilverlightTest
{

    //
    // You can add custom execution steps by simply
    // adding a void function and decorating it with the [CodedStep] 
    // attribute to the test method. 
    // Those steps will automatically show up in the test steps on save.
    //
    // The BaseWebAiiTest exposes all key objects that you can use
    // to access the current testcase context. [i.e. ActiveBrowser, Find ..etc]
    //
    // Data driven tests can use the Data[columnIndex] or Data["columnName"] 
    // to access data for a specific data iteration.
    //
    // Example:
    //
    // [CodedStep("MyCustom Step Description")]
    // public void MyCustomStep()
    // {
    //        // Custom code goes here
    //      ActiveBrowser.NavigateTo("http://www.google.com");
    //
    //        // Or
    //        ActiveBrowser.NavigateTo(Data["url"]);
    // }
    //
        

    public class DataForm : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"Type 'Darren' into Item1Textbox", RequiresSilverlight=true)]
        public void DataForm_CodedStep()
        {
            SilverlightApp app = ActiveBrowser.SilverlightApps()[0];
            // Type 'Darren' into Item1Textbox
            Pages.TelerikDataFormFor.SilverlightApp.Item1Textbox.SetText(true, "Darren", 10, 100, false);
        }
    
        //[CodedStep(@"New Coded Step")]
        //public void DataForm_CodedStep1()
        //{
            
        //}
    
        [CodedStep(@"Verify Item2Textboxview's visibility is Visible", RequiresSilverlight=true)]
        public void DataForm_CodedStep1()
        {
            // Verify Item2Textboxview's visibility is Visible
            Assert.AreEqual(ArtOfTest.WebAii.Silverlight.UI.Visibility.Visible, Pages.TelerikDataFormFor.SilverlightApp.Item2Textboxview.ComputedVisibility, "Element visibility does not match expected value");
        }
    
        [CodedStep(@"Click BeginEditRadbutton", RequiresSilverlight=true)]
        public void DataForm_CodedStep2()
        {
            // Click BeginEditRadbutton
            Pages.TelerikDataFormFor.SilverlightApp.BeginEditRadbutton.User.Click(ArtOfTest.WebAii.Core.MouseClickType.LeftClick, 6, 6, ArtOfTest.Common.OffsetReference.TopLeftCorner, ArtOfTest.Common.ActionPointUnitType.Pixel);
            
        }
    }
}
