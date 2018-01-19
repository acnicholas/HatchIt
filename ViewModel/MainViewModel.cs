

namespace Hatchit.ViewModel
{
    using System.Windows.Input;
    using System.ComponentModel;
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;
    using System.Windows;
    using System;

    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public ICommand SaveCommand { get; private set; }
        public ICommand OpenCommand { get; private set; }
        public ICommand CloseCommand { get; private set; }

        public MainViewModel()
        {
            SaveCommand = new RelayCommand(Save);
            OpenCommand = new RelayCommand(Open);
            CloseCommand = new RelayCommand(Close);
        }

        private void Save()
        {
            System.Diagnostics.Debug.WriteLine("Save Cicked");
        }

        private void Open()
        {
            System.Diagnostics.Debug.WriteLine("Open Cicked");
        }

        private void Close()
        {
            System.Diagnostics.Debug.WriteLine("Close Cicked");
        }

    }
}