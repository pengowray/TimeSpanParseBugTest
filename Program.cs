using System;

public class Program {
    public static void Main(string[] args) {
        string a = "0:00:00.01";
        string b = "0:00:00.01000000";  // 8 decimal digits
        string c = "0:00:00.010000000"; // 9 decimal digits

        TimeSpan aTimeSpan;
        TimeSpan bTimeSpan;
        TimeSpan cTimeSpan;

        string aText;
        string bText;
        string cText;

        try {
            aTimeSpan = System.TimeSpan.Parse(a);
            aText = aTimeSpan.TotalMilliseconds + " ms";
        } catch (System.OverflowException) {
            aText = "OverflowException";
        } catch (System.FormatException) {
            aText = "FormatException";
        }

        try {
            bTimeSpan = System.TimeSpan.Parse(b);
            bText = bTimeSpan.TotalMilliseconds + " ms";
        } catch (System.OverflowException) {
            bText = "OverflowException";
        } catch (System.FormatException) {
            bText = "FormatException";
        }

        try {
            cTimeSpan = System.TimeSpan.Parse(c);
            cText = cTimeSpan.TotalMilliseconds + " ms";
        } catch (System.OverflowException) {
            cText = "OverflowException";
        } catch (System.FormatException) {
            cText = "FormatException";
        }

        string version = Environment.Version.ToString();
        string assemblyFullName = typeof(TimeSpan).Assembly.FullName;
        string imageRuntimeVersion = typeof(TimeSpan).Assembly.ImageRuntimeVersion;

        Console.WriteLine("| version | `{0}` | `{1}` | `{2}` | Assembly.FullName | ImageRuntimeVersion | Notes |", a, b, c);
        Console.WriteLine("| --- | --- | --- | --- | --- | --- | --- |");
        Console.WriteLine("| {0} | `{1}` | `{2}` | `{3}` | {4} | {5} | | ", version, aText, bText, cText, assemblyFullName, imageRuntimeVersion);
    }
}
