using System;
using System.Collections.Generic;
using System.Text;

public class LogModel
{
    public string ExcMessage { get; set; }
    public Exception ExceptionModel { get; set; }
}

public interface ILog
{
    void Log(LogModel entry);
}
