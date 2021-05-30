﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelBuilder;
using ModelParameters;

namespace OrsaprBedUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Словарь для хранения сведений о TextBox
        /// </summary>
        private readonly Dictionary<TextBox, Action<ModelParameters.BedParameters, string>>
            _textBoxDictionary;

        /// <summary>
        /// Поле хранящее данные о лампе
        /// </summary>
        private BedParameters _nightstand = new BedParameters { };

        /// <summary>
        /// Поле для хранения данных о билдере
        /// </summary>
        private BedBuilder _build = new BedBuilder();

        /// <summary>
        /// Лист параметров
        /// </summary>
        private readonly List<Parameter> _parameters;

        /// <summary>
        /// Лист c текстбоксами
        /// </summary>
        private readonly List<TextBox> _textBoxList;

        /// <summary>
        /// Лист c текстбоксами
        /// </summary>
        private readonly List<Label> _labelList;

        public MainForm()
        {
            InitializeComponent();
            _textBoxDictionary = new Dictionary<TextBox, Action<BedParameters, string>>()
            {
                {
                    textBoxWidth,
                    (BedParameters nightstand, string text) =>
                    {
                        nightstand.Width.Value = double.Parse(text);
                    }
                },
                {
                    textBoxLength,
                    (BedParameters nightstand, string text) =>
                    {
                        nightstand.Length.Value = double.Parse(text);
                    }
                },
                {
                    textBoxHeight,
                    (BedParameters nightstand, string text) =>
                    {
                        nightstand.Height.Value = double.Parse(text);
                    }
                },
                {
                    textBoxThickness,
                    (BedParameters nightstand, string text) =>
                    {
                        nightstand.Thickness.Value = double.Parse(text);
                    }
                },
                {
                    textBoxDistance,
                    (BedParameters nightstand, string text) =>
                    {
                        nightstand.Distance.Value = double.Parse(text);
                    }
                }

             };

            _parameters = new List<Parameter>
            {
                _nightstand.Width,
                _nightstand.Length,
                _nightstand.Height,
                _nightstand.Thickness,
                _nightstand.Distance,
            };

            _textBoxList = new List<TextBox>()
            {
                textBoxWidth,
                textBoxLength,
                textBoxHeight,
                textBoxThickness,
                textBoxDistance,

            };

            _labelList = new List<Label>
            {
                labelWidth,
                labelLength,
                labelHeight,
                labelThickness,
                labelDistance,
            };

            _nightstand.DefaultValue();
            UpdateFormFields();
            SetLimits();
        }


        /// <summary>
        /// Обработчик для присваивания значений из TextBox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxLeave(object sender, EventArgs e)
        {
            var currentTextBox = (TextBox)sender;
            var currentAction = _textBoxDictionary[currentTextBox];
            if (!String.IsNullOrEmpty(currentTextBox.Text))
            {
                try
                {
                    currentAction.Invoke(_nightstand, currentTextBox.Text);
                    currentTextBox.BackColor = Color.White;
                    SetLimits();
                    UpdateFormFields();
                    if (Validate())
                    {
                        buttonBuildBed.Enabled = true;
                    }
                }
                catch (ArgumentException exception)
                {
                    currentTextBox.BackColor = Color.LightCoral;
                    MessageBox.Show(exception.Message);
                    buttonBuildBed.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Метод для проверки на соответствие сохраненных и введенных параметров
        /// </summary>
        /// <returns></returns>
        private bool Validate()
        {
            var smallestUpperBound = Math.Min(_textBoxList.Count, _parameters.Count);
            for (var index = 0; index < smallestUpperBound; index++)
            {
                if (_textBoxList[index].Text.ToString() != _parameters[index].Value.ToString())
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Метод, присваивающий значение предустановленных параметров в TextBox
        /// </summary>
        private void UpdateFormFields()
        {
            var smallestUpperBound = Math.Min(_textBoxList.Count, _parameters.Count);
            for (var index = 0; index < smallestUpperBound; index++)
            {
                _textBoxList[index].Text = _parameters[index].Value.ToString();
            }
        }

        /// <summary>
        /// Метод для проброса минимальных и максимальных параметров в label формы
        /// </summary>
        private void SetLimits()
        {
            var smallestUpperBound = Math.Min(_labelList.Count, _parameters.Count);
            for (var index = 0; index < smallestUpperBound; index++)
            {
                _labelList[index].Text = Convert.ToString($"{_parameters[index].NameParameter} " +
                                                          $"({_parameters[index].MinimumValue} - " +
                                                          $"{_parameters[index].MaximumValue}) mm");
            }
        }

        private void buttonBuildBed_Click(object sender, EventArgs e)
        {
            _build.BuildNightstand(_nightstand);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}


