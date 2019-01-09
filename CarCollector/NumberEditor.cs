using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CarCollector
{
    public partial class NumberEditor : UserControl
    {
        (string Charackters, string Numbers, string Region, string Other) CashedNumbers;
        public NumberEditor()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        public object DataSource
        {
            set => bsNumber.DataSource = value;
            get => bsNumber.DataSource;
        }

        private void OnIsRusChanged(object sender, EventArgs e)
        {
            void ChangeEnable(bool isRus)
            {
                tbCharacters.Enabled = isRus;
                tbNumbers.Enabled = isRus;
                tbRegion.Enabled = isRus;
                tbOther.Enabled = !isRus;
            }
            if (rbRus.Checked)
            {
                CashedNumbers.Other = tbOther.Text;
                TextBoxSetText(lbOther, tbOther, rbOther, "", OtherValidate);

                TextBoxSetText(lbCharacters, tbCharacters, rbRus, CashedNumbers.Charackters, CharactersValidate);
                TextBoxSetText(lbNumbers, tbNumbers, rbRus, CashedNumbers.Numbers, NumbersValidate);
                TextBoxSetText(lbRegion, tbRegion, rbRus, CashedNumbers.Region, RegionValidate);

                ChangeEnable(true);
            }
            else
            {
                CashedNumbers.Charackters = tbCharacters.Text;
                CashedNumbers.Numbers = tbNumbers.Text;
                CashedNumbers.Region = tbRegion.Text;

                TextBoxSetText(lbCharacters, tbCharacters, rbRus, "", CharactersValidate);
                TextBoxSetText(lbNumbers, tbNumbers, rbRus, "", NumbersValidate);
                TextBoxSetText(lbRegion, tbRegion, rbRus, "", RegionValidate);

                TextBoxSetText(lbOther, tbOther, rbOther, CashedNumbers.Other, OtherValidate);
                ChangeEnable(false);
            }
        }
        private void TextBoxSetText(Label label, TextBox textBox, RadioButton radioButton, string text, Func<string, bool> validator)
        {
            textBox.Text = text;
            ControlVaidating(label, textBox, radioButton, validator);
        }
        private void OnDatasourceChanged(object sender, EventArgs e)
        {
            void StopUpdating(object s, BindingCompleteEventArgs arg)
            {
                arg.Binding.ControlUpdateMode = ControlUpdateMode.Never;
            }
            var current = (Model.Data.CarNumber)bsNumber.Current;
            CashedNumbers = (current.Characters, current.Numbers?.ToString() ?? "", current.Region?.ToString() ?? "", current.Other);

            var binding = new Binding("Text", sender, "Characters", true, DataSourceUpdateMode.OnPropertyChanged);
            binding.BindingComplete += StopUpdating;
            tbCharacters.DataBindings.Add(binding);
            binding = new Binding("Text", sender, "Numbers", true, DataSourceUpdateMode.OnPropertyChanged, "");
            binding.BindingComplete += StopUpdating;
            tbNumbers.DataBindings.Add(binding);
            binding = new Binding("Text", sender, "Region", true, DataSourceUpdateMode.OnPropertyChanged, "");
            binding.BindingComplete += StopUpdating;
            tbRegion.DataBindings.Add(binding);
            binding = new Binding("Text", sender, "Other", true, DataSourceUpdateMode.OnPropertyChanged);
            binding.BindingComplete += StopUpdating;
            tbOther.DataBindings.Add(binding);
            binding = new Binding("Text", sender, "Comments", true, DataSourceUpdateMode.OnPropertyChanged);
            binding.BindingComplete += StopUpdating;
            tbComments.DataBindings.Add(binding);
            binding = new Binding("Checked", sender, "IsRus", true, DataSourceUpdateMode.OnPropertyChanged);
            binding.BindingComplete += StopUpdating;
            rbRus.DataBindings.Add(binding);
            binding = new Binding("Checked", sender, "IsRus", true, DataSourceUpdateMode.OnPropertyChanged);
            void BoolInvert(object s, ConvertEventArgs arg) => arg.Value = !(bool)arg.Value;
            binding.Parse += BoolInvert;
            binding.Format += BoolInvert;
            binding.BindingComplete += StopUpdating;
            rbOther.DataBindings.Add(binding);
            Validation();
        }



        private void OnCharactersChanged(object sender, EventArgs e) => ControlVaidating(lbCharacters, tbCharacters, rbRus, CharactersValidate);
        private void OnNumbersChanged(object sender, EventArgs e) => ControlVaidating(lbNumbers, tbNumbers, rbRus, NumbersValidate);
        private void OnRegionChanged(object sender, EventArgs e) => ControlVaidating(lbRegion, tbRegion, rbRus, RegionValidate);
        private void OnOtherChanged(object sender, EventArgs e) => ControlVaidating(lbOther, tbOther, rbOther, OtherValidate);

        private void ControlVaidating(Label label, TextBox textBox, RadioButton radioButton, Func<string, bool> validator)
        {
            if (radioButton.Checked)
            {
                if (!validator(textBox.Text))
                {
                    label.ForeColor = Color.Red;
                    Validation(false);
                }
                else
                {
                    label.ForeColor = Color.Black;
                    Validation();
                }
            }
            else label.ForeColor = Color.Black;
        }
        private bool _validationState;
        private void Validation(bool newValidationState)
        {
            if (_validationState == newValidationState) return;
            _validationState = newValidationState;
            OnValidation(new EventArgs<bool> { Value = newValidationState });
        }
        private void Validation()
        {
            bool result = rbRus.Checked ?
                CharactersValidate(tbCharacters.Text) &&
                NumbersValidate(tbNumbers.Text) &&
                RegionValidate(tbRegion.Text) :
                OtherValidate(tbOther.Text);
            Validation(result);
        }
        private static readonly Regex _engChars = new Regex("^[a-z]{3}$");
        private static readonly Regex _digs = new Regex("^[\\d]{3}$");
        private static readonly Regex _regionDigs = new Regex("^[\\d]{2,3}$");
        private bool CharactersValidate(string text) => !String.IsNullOrWhiteSpace(text) && _engChars.IsMatch(text);
        private bool NumbersValidate(string text) => !String.IsNullOrWhiteSpace(text) && _digs.IsMatch(text);
        private bool RegionValidate(string text) => !String.IsNullOrWhiteSpace(text) && _regionDigs.IsMatch(text);
        private bool OtherValidate(string text) => !String.IsNullOrWhiteSpace(text);
        public event EventHandler<EventArgs<bool>> NumberValidated;
        protected void OnValidation(EventArgs<bool> arg) => NumberValidated?.Invoke(this, arg);
    }
}
