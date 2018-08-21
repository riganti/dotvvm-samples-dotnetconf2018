using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;

namespace DotNetConfDemo3.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {

        public int Number1 { get; set; }

        public int Number2 { get; set; }

        public bool AllowNumber3 { get; set; }

        public int? Number3 { get; set; }

        public int Result { get; set; }


        public void Calculate()
        {
            Result = Number1 + Number2;
            if (AllowNumber3)
            {
                Result += Number3 ?? 0;
            }
        }
    }
}
