namespace StyleCop.Console
{
    internal class RunnerArguments : CommandLineArguments
    {
        public RunnerArguments(string[] args)
            : base(args)
        {
        }

        public string ProjectPath
        {
            get { return this["project-path"] ?? this["p"]; }
        }

        public bool NotRecursive
        {
            get { return (this["not-recursively"] ?? this["n"]) != null; }
        }

        public bool Help
        {
            get { return (this["help"] ?? this["?"]) != null; }
        }

        public string SettingsLocation
        {
            get { return this["settings-location"] ?? this["s"]; }
        }

        public string OutFile
        {
            get { return this["output-xml"] ?? this["o"]; }
        }
        public string OutCSV
        {
            get { return this["output-csv"] ?? this["c"]; }
        }

        public bool NoConsoleOutput
        {
            get { return (this["no-console"] ?? this["x"]) != null; }
        }
    }
}
