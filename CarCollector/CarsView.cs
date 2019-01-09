using Model;
using Model.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCollector
{
    public partial class CarsView : Form
    {
        private MainWindowModel _model;
        public CarsView()
        {
            InitializeComponent();
        }
        protected override async void OnLoad(EventArgs e)
        {
            _model = new MainWindowModel();
            bsCars.DataSource = await _model.GetCars();
            bsCars.AddingNew += OnAddingNew;
            base.OnLoad(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            _model.Dispose();
            base.OnClosed(e);
        }

        private async void OnCarDoubleClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tbNumbere.Index)
            {
                var car = (Car)bsCars.Current;
                var newNumber = car.CarNumber?.Copy ?? new CarNumber();
                var editView = new NumberEditView(newNumber);
                switch (editView.ShowDialog())
                {
                    case DialogResult.OK:
                        car.CarNumber = newNumber;
                        bsCars.ResetBindings(false);
                        await _model.AddOrUpdate(car);
                        break;
                };
            }
        }


        private void OnAddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Car { CarNumber = new CarNumber { IsRus = true } };
        }

        private async void OnCarsChangedAsync(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    break;
                case ListChangedType.ItemChanged:
                    await _model.UpdateIfNeeded((Car)bsCars[e.NewIndex]);
                    break;
            }
        }

        private async void OnCarDeletingAsync(object sender, DataGridViewRowCancelEventArgs e)
        {
            var deleting = (Car)e.Row.DataBoundItem;
            await _model.DeleteIfNeeded(deleting);
        }
    }
}
