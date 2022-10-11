using System;

namespace SoftServe_IT_Academy.Tasks._Solid
{
    public interface ILead
    {
        void AssignTask();
        void CreateSubTask();
    }
    public interface IProgrammer
    {
        void WorkOnTask();
    }
    public class TeamLead : ILead, IProgrammer
    {
        public void AssignTask() => throw new NotImplementedException();

        public void CreateSubTask() => throw new NotImplementedException();

        public void WorkOnTask() => throw new NotImplementedException();
    }
    public class Manager : ILead
    {
        public void AssignTask() => throw new NotImplementedException();

        public void CreateSubTask() => throw new NotImplementedException();
    }
    public class Programmer : IProgrammer
    {
        public void WorkOnTask() => throw new NotImplementedException();
    }
}
