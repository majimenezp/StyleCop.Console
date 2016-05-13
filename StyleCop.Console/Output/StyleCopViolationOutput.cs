using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleCop.Console.Output
{
    public class StyleCopViolationOutput
    {
        public int LineNumber { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }

        public string FileType { get; set; }

        public string RuleId { get; set; }

        public string RuleName { get; set; }

        public string RuleDescription { get; set; }

        public string RuleNameSpace { get; set; }

        public string Message { get; set; }

        public StyleCopViolationOutput()
        {
                
        }

        public StyleCopViolationOutput(ViolationEventArgs violationEvent)
        {
            this.LineNumber = violationEvent.LineNumber;
            this.FilePath = violationEvent.SourceCode.Path;
            this.FileName = violationEvent.SourceCode.Name;
            this.FileType = violationEvent.SourceCode.Type;
            this.RuleId = violationEvent.Violation.Rule.CheckId;
            this.RuleName = violationEvent.Violation.Rule.Name;
            this.RuleDescription = violationEvent.Violation.Rule.Description;
            this.RuleNameSpace = violationEvent.Violation.Rule.Namespace;
            this.Message = violationEvent.Message;
        }

        
    }
}
