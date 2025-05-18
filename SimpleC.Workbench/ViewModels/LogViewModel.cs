using System;

namespace SimpleC.Workbench.ViewModels
{
    public enum LogType
    {
        Message,
        Code
    }
    public enum LogSeverity
    {
        Info,
        Warning,
        Error
    }

    public class LogViewModel : ViewModelBase
    {
        LogType _type;
        LogSeverity _severity;
        string _message;
        DateTime _timestamp;

        public LogType Type
        {
            get { return _type; }
            set { this.SetProperty(ref _type, value); }
        }
        public LogSeverity Severity
        {
            get { return _severity; }
            set { this.SetProperty(ref _severity, value); }
        }
        public string Message
        {
            get { return _message; }
            set { this.SetProperty(ref _message, value); }
        }
        public DateTime Timestamp
        {
            get { return _timestamp; }
            set { this.SetProperty(ref _timestamp, value); }
        }

        public LogViewModel()
        {
            this.Message = "";
            this.Timestamp = DateTime.Now;
        }

    }
}
