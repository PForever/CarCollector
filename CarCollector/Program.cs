using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormHelpLibrary.FilterHelp;
using WindowsFormHelpLibrary.SortableBindingList;


namespace CarCollector
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var listOwners = new List<Owner>{new Owner("OneO"), new Owner("TwoO")};
            var list = new List<Bitch>
                {new Bitch("One", listOwners[0]),new Bitch("One", listOwners[1]),new Bitch("One", listOwners[0]), new Bitch("Two", listOwners[0]), new Bitch("Three", listOwners[1])};
            var filter = new TypeFilter($"Name = \"One\"",
                new Dictionary<string, TypeFilter> {{nameof(Bitch.Owner), new TypeFilter("NameOwner = \"OneO\"") }});
            var sortedList = new SortableBindingList<Bitch>(list);
            var mainFilter = new TypeFilter("", new Dictionary<string, TypeFilter> { { "Bitch", filter } });
            //sortedList.ApplyFilter(filter);
            //var t = (Func<MainBitch, bool>)PropertiesFilter.TypeValidatorExpression(typeof(MainBitch), new Dictionary<string, TypeFilter>{{"Bitch", filter}}).Compile();
            var t = PropertiesFilter.CreateFilter<MainBitch>(mainFilter);
            var p = t(new MainBitch{Bitch = list[1]});
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CarsView());
        }
    }
}
