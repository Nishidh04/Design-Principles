using System;

namespace Design_Principles.SOLID.LiskovSubstitution
{
    
    // We treat FinanceOfficer as a "kind of" Developer and pass it to code expecting Developer behavior.
    

    internal class LspViolated
    {
        public void RunExample()
        {
            

            Developer dev = new SoftwareEngineer();
            Developer financeAsDev = new FinanceOfficer();

            DeployFeature(dev);           
            DeployFeature(financeAsDev);  //Surprising behavior (throws)
        }

        
        private void DeployFeature(Developer developer)
        {
            developer.WriteCode();  // Expected capability
            developer.Deploy();     // Expected capability
            Console.WriteLine("Feature deployed.\n");
        }
    }

    // Base abstraction 
    internal abstract class Developer
    {
        public abstract void WriteCode();
        public abstract void Deploy();
    }

    internal class SoftwareEngineer : Developer
    {
        public override void WriteCode() => Console.WriteLine("SoftwareEngineer: Writing code...");
        public override void Deploy() => Console.WriteLine("SoftwareEngineer: Deploying application...");
    }

    // FinanceOfficer is forced into Developer hierarchy
    internal class FinanceOfficer : Developer
    {
        // Breaking expected behavior: throws instead of performing the expected action.
        public override void WriteCode() => throw new NotSupportedException("FinanceOfficer cannot write code.");
        public override void Deploy() => throw new NotSupportedException("FinanceOfficer cannot deploy.");
    }
}