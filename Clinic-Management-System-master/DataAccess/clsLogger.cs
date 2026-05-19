using System;
using System.Diagnostics;

public static class clsLogger
{
    private static readonly string SourceName = "ClinicManagement";
    private static readonly string LogName = "Application";

    static clsLogger()
    {
        try
        {
            if(!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, LogName);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Failed to create Event Source: " + ex.Message);
        }
    }

    public static void Log(string message, EventLogEntryType logType = EventLogEntryType.Information)
    {
        try
        {
            using(EventLog eventLog = new EventLog(LogName))
            {
                eventLog.Source = SourceName;
                eventLog.WriteEntry(message, logType);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Event Viewer Logging failed: " + ex.Message);
        }
    }
    public static void LogError(Exception ex)
    {
        Log($"Exception: {ex.Message}\nStackTrace: {ex.StackTrace}", EventLogEntryType.Error);
    }
}
