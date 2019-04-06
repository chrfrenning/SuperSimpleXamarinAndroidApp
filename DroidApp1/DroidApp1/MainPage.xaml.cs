using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DroidApp1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public DeveloperInfo DevInfo = new DeveloperInfo { Name = "Christopher Frenning" };
        public DeveloperList Devs { get; private set; }

        public MainPage()
        {

            InitializeComponent();

            //lbl.BindingContext = DevInfo;
            Devs = new DeveloperList();

            Devs.Add(new DeveloperInfo() { Name = "Trudy" });
            Devs.Add(new DeveloperInfo() { Name = "Andy" });
            Devs.Add(new DeveloperInfo() { Name = "Sue" });
            Devs.Add(new DeveloperInfo() { Name = "John" });


            BindingContext = this;
        }
    }

    public class DeveloperInfo
    {
        private string avatarUrl;
        private string name;

        public DeveloperInfo()
        {
            AvatarUrl = "https://en.gravatar.com/avatar/500e3c86a5425f2fd6ace652cb693f61";
        }

        public string Name { get { return name; } set => name = value; }
        public string AvatarUrl { get { return avatarUrl; } set => avatarUrl = value; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class DeveloperList : List<DeveloperInfo>
    {
        public DeveloperList()
        {
        }
    }
}
