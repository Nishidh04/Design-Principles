using System;

namespace Design_Principles.SOLID.InterfaceSegregation
{

    internal class IspViolated
    {
        public void RunExample()
        {
            ISoftwareEngineer hr = new HR();

            // These will cause errors ISP violated
            hr.WriteCode();
            hr.DeployCode();
        }
    }
    // Contains methods only a Software Engineer should use
    interface ISoftwareEngineer
    {
        void WriteCode();
        void DeployCode();
    }

    // HR is forced to implement coding methods they do NOT use
    class HR : ISoftwareEngineer
    {
        public void WriteCode()
        {
            throw new NotSupportedException("HR does not write code.");
        }

        public void DeployCode()
        {
            throw new NotSupportedException("HR does not deploy code.");
        }
    }

    
}