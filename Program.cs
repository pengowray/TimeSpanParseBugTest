using System;

public class Program {
    public static void Main(string[] args) {
        string a = "0:00:00.01";
        string b = "0:00:00.01000000";  // 8 decimal digits
        string c = "0:00:00.010000000"; // 9 decimal digits

        string aText = TimeSpanParseToString(a);
        string bText = TimeSpanParseToString(b);
        string cText = TimeSpanParseToString(c);

        string version = Environment.Version.ToString();
        string assemblyFullName = typeof(TimeSpan).Assembly.FullName;
        string imageRuntimeVersion = typeof(TimeSpan).Assembly.ImageRuntimeVersion;

        Console.WriteLine("| version | `{0}` | `{1}` | `{2}` | Assembly.FullName | ImageRuntimeVersion | Notes |", a, b, c);
        Console.WriteLine("| --- | --- | --- | --- | --- | --- | --- |");
        Console.WriteLine("| {0} | `{1}` | `{2}` | `{3}` | {4} | {5} | | ", version, aText, bText, cText, assemblyFullName, imageRuntimeVersion);
    }

    public static string TimeSpanParseToString(string spanString) {
        try {
            TimeSpan timespan = System.TimeSpan.Parse(spanString);
            return timespan.TotalMilliseconds + " ms";
        } catch (System.OverflowException) {
            return "OverflowException";
        } catch (System.FormatException) {
            return "FormatException";
        }

        return "???";
    }
}
