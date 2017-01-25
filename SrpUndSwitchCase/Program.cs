using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrpUndSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new Processor();

            processor.DoSomething(States.Started);

            Console.ReadKey();
        }
    }

    class Processor
    {
        private readonly Dictionary<string, ProcessorAction> _actions;

        public Processor()
        {
            _actions = new Dictionary<string, ProcessorAction>();

            _actions.Add(States.Started, new StartedProcessorAction());
            _actions.Add(States.Stopped, new StoppedProcessorAction());
            _actions.Add(States.Running, new RunningProcessorAction());
        }

        public void DoSomething(string state)
        {
            var action = _actions[state];
            action.Do();
        }
    }

    abstract class ProcessorAction
    {
        public abstract void Do();
    }

    class StartedProcessorAction : ProcessorAction
    {
        public override void Do()
        {
            Console.WriteLine("Action for Started");
        }
    }

    class StoppedProcessorAction : ProcessorAction
    {
        public override void Do()
        {
            Console.WriteLine("Action for Stopped");
        }
    }

    class RunningProcessorAction : ProcessorAction
    {
        public override void Do()
        {
            Console.WriteLine("Action for Running");
        }
    }

    static class States
    {
        public const string Started = "##STARTED##";
        public const string Stopped = "##STARTED##";
        public const string Running = "##STARTED##";
    }

    enum Actions
    {
        Add = 1,
        Remove = 2,
        Delete = 3
    }
}
