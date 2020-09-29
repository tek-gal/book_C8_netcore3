using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Instrumenting {
    class Program {
        static void Main(string[] args) {
            // write ro a text file in the project folder
            Trace.Listeners.Add(new TextWriterTraceListener(
                File.CreateText("log.txt")
            ));

            // now text writer is buffered, so this option calls 
            // Flush() on all listeners after writing 
            // text buffer imporeves performing because the data aren't written 
            // in the file every time it calls
            // instead it is written to the bufferand then when it's full
            // is written to the file
            // to switch of this behavior write 'false'
            // and Flush() will be called every time you call Write
            Trace.AutoFlush = true;

            Debug.WriteLine("Debug says, I'm watching!");
            Trace.WriteLine("Trace says, I'm watching!");

            // create a conf builder that looks in the current folder for appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",
                optional: true, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            var ts = new TraceSwitch(
                displayName: "PacktSwitch",
                description: "This switch is set via a JSON config."
            );

            configuration.GetSection("PacktSwitch").Bind(ts);

            Trace.WriteLine(ts.TraceError, "Trace error");
            Trace.WriteLine(ts.TraceWarning, "Trace warning");
            Trace.WriteLine(ts.TraceInfo, "Trace info");
            Trace.WriteLine(ts.TraceVerbose, "Trace verbose");
        }
    }
}