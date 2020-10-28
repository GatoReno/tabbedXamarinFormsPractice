using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;
//using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
namespace Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyTabbedPage : Xamarin.Forms.TabbedPage
    {
        public MyTabbedPage()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            
            //On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            //On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);

        }

        
    }
}
