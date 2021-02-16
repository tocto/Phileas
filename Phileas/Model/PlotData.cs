﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phileas.Model
{
    public class PlotData : INotifyPropertyChanged
    {
        private string title = string.Empty;

        private string xAxisTitle = string.Empty;
        
        private string yAxisTitle = string.Empty;

        private uint numberOfSteps = 100;

        private Dictionary<string, List<double>> dataPoints = new Dictionary<string, List<double>>();

        private string xParameterKey { get; set; } = string.Empty;

        private string yParameterKey { get; set; } = string.Empty;

        private bool isLineSmothnessOn = false;

        public string Title
        {
            get => this.title;

            set
            {
                if (this.title != value)
                {
                    this.title = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Title"));
                }
            }
        }

        public string XAxisTitle
        {
            get => this.xAxisTitle;

            set
            {
                if (this.xAxisTitle != value)
                {
                    this.xAxisTitle = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("XAxisTitle"));
                }
            }
        }

        public string YAxisTitle
        {
            get => this.yAxisTitle;

            set
            {
                if (this.yAxisTitle != value)
                {
                    this.yAxisTitle = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("YAxisTitle"));
                }
            }
        }

        public uint NumberOfSteps
        {
            get => this.numberOfSteps;

            set
            {
                if (this.numberOfSteps != value)
                {
                    this.numberOfSteps = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NumberOfSteps"));
                }
            }
        }

        public Dictionary<string, List<double>> DataPoints
        {
            get => this.dataPoints;

            set
            {
                if (this.dataPoints != value)
                {
                    this.dataPoints = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DataPoints"));
                }
            }
        }

        public string XParameterKey
        {
            get => this.xParameterKey;

            set
            {
                if (this.xParameterKey != value)
                {
                    this.xParameterKey = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("XParameterKey"));
                }
            }
        }

        public string YParameterKey
        {
            get => this.yParameterKey;

            set
            {
                if (this.yParameterKey != value)
                {
                    this.yParameterKey = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("YParameterKey"));
                }
            }
        }

        public bool IsLineSmothnessOn
        {
            get => this.isLineSmothnessOn;

            set
            {
                if (this.isLineSmothnessOn != value)
                {
                    this.isLineSmothnessOn = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsLineSmothnessOn"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
