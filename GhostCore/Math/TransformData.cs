using GhostCore.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace GhostCore.Math
{
    public class TransformData
    {
        public double TranslateX { get; set; }
        public double TranslateY { get; set; }
        public double Rotation { get; set; }
        public double ScaleX { get; set; } = 1;
        public double ScaleY { get; set; } = 1;
    }

    public class ObservableTransformData : NotifyPropertyChangedImpl
    {
        public event EventHandler<(double, double)> ScaleChanged;

        private double _translateX;
        private double _translateY;
        private double _rotation;
        private double _scaleX = 1;
        private double _scaleY = 1;

        public double TranslateX
        {
            get { return _translateX; }
            set { _translateX = value; OnPropertyChanged(nameof(TranslateX)); }
        }

        public double TranslateY
        {
            get { return _translateY; }
            set { _translateY = value; OnPropertyChanged(nameof(TranslateY)); }
        }

        public double Rotation
        {
            get { return _rotation; }
            set { _rotation = value; OnPropertyChanged(nameof(Rotation)); }
        }

        public double ScaleX
        {
            get { return _scaleX; }
            set
            {
                _scaleX = value; 
                OnPropertyChanged(nameof(ScaleX));
                OnPropertyChanged(nameof(InverseScaleX));
                ScaleChanged?.Invoke(this, (_scaleX, _scaleY));
            }
        }

        public double ScaleY
        {
            get { return _scaleY; }
            set
            {
                _scaleY = value; 
                OnPropertyChanged(nameof(ScaleY));
                OnPropertyChanged(nameof(InverseScaleY));
                ScaleChanged?.Invoke(this, (_scaleX, _scaleY));
            }
        }

        public double UniformScale
        {
            get { return _scaleX; }
            set
            {
                _scaleX = value;
                _scaleY = value;
                OnPropertyChanged(nameof(ScaleX));
                OnPropertyChanged(nameof(InverseScaleX));
                OnPropertyChanged(nameof(ScaleY));
                OnPropertyChanged(nameof(InverseScaleY));

                ScaleChanged?.Invoke(this, (_scaleX, _scaleY));
            }
        }

        public double InverseScaleX
        {
            get { return 1 / _scaleX; }
        }

        public double InverseScaleY
        {
            get { return 1 / _scaleY; }
        }
    }
}
