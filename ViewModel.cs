using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Hatchit
{
    class ViewModel : INotifyPropertyChanged
    {
        private bool canExecute;
        private Hatch hatch;
        private ICommand clickCommand;
        private ObservableCollection<System.Windows.Shapes.Line> lines;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<System.Windows.Shapes.Line> Lines
        {
            get
            {
                return this.lines;
            }
            set
            {
                if (value != this.lines)
                {
                    this.lines = value;
                    InvokePropertyChanged("Lines");
                }
            }
        }

        public ICommand ClickCommand
        {
            get
            {
                return clickCommand ?? (clickCommand = new CommandHandler(() => MyAction(), canExecute));
            }
        }

        public void MyAction()
        {
            lines.Add(TestLine());
        }

        public ViewModel()
        {
            canExecute = true;
            this.hatch = new Hatch();
            lines = new ObservableCollection<System.Windows.Shapes.Line>();
            //lines.Add(TestLine());
        }

        private void InvokePropertyChanged(string propertyName)

        {
            var e = new PropertyChangedEventArgs(propertyName);
            PropertyChangedEventHandler changed = PropertyChanged;
            if (changed != null) changed(this, e);
        }

        private System.Windows.Shapes.Line TestLine()
        {
            DoubleCollection dashArray = new DoubleCollection();
            dashArray.Add(10);
            dashArray.Add(10);

            var testLine = new System.Windows.Shapes.Line();
            testLine.Visibility = System.Windows.Visibility.Visible;
            testLine.StrokeThickness = 4;
            testLine.Stroke = System.Windows.Media.Brushes.Black;
            testLine.StrokeDashArray = dashArray;
            testLine.X1 = 0;
            testLine.X2 = 300;
            testLine.Y1 = 0;
            testLine.Y2 = 300;

            ScaleTransform st = new ScaleTransform(2, 2);
            RotateTransform rt = new RotateTransform(45);
            testLine.RenderTransform = rt;

            TranslateTransform tt = new TranslateTransform(100, 100);
            testLine.RenderTransform = tt;

            return testLine;
        }
    }
}

