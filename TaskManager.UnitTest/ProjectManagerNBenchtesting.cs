using NBench;
using TaskManager.API;

namespace FSE_ProjectManagerApi.Test
{

    public class ProjectManagerNBenchtesting
    {
        private Counter addCounter;
        private int key;
        private const string AddCounterName = "AddCounter";
        private const int AcceptableMinAddThroughput = 100;

        [PerfSetup]
        public void Setup(BenchmarkContext context)
        {
            addCounter = context.GetCounter(AddCounterName);
            key = 0;
        }


        [PerfBenchmark(NumberOfIterations = 50, RunMode = RunMode.Throughput, RunTimeMilliseconds = 60000, TestMode = TestMode.Measurement)]
        [CounterMeasurement(AddCounterName)]
        [CounterThroughputAssertion(AddCounterName, MustBe.GreaterThan, AcceptableMinAddThroughput)]
        public void GetUsersThroughputBenchMark(BenchmarkContext context)
        {
            TaskManager.BL.UsersBO usersBO = new TaskManager.BL.UsersBO();
            usersBO.GetAll();
            addCounter.Increment();
        }


    }
}
