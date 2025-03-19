namespace EventLoop
{
    public class EventLoopReadyTest
    {
        EventLoop _eventLoop = new EventLoop();

        void CountUp(int stop, int x = 0)
        {
            if (x < stop)
            {
                Console.WriteLine("Up " + x);
                _eventLoop.AddLater(() => CountUp(stop, x + 1), 1);
            }
        }
        void CountDown(int n)
        {
            if (n > 0)
            {
                Console.WriteLine("Down " + n);
                _eventLoop.AddLater(() => CountDown(n - 1), 4);
            }
        }
        public void GO()
        {
            _eventLoop.Add(() => CountUp(20));
            _eventLoop.Add(() => CountDown(5));
            _eventLoop.Run();
        }
    }


    class EventLoop
    {
        // For tasks that are ready to run immediately.
        private readonly Queue<Action> _ready;

        // For tasks scheduled to run in the future, prioritized by their deadline.
        private readonly PriorityQueue<(Action func, DateTime deadline), DateTime> _sleeping;

        public EventLoop()
        {
            _ready = new Queue<Action>();
            _sleeping = new PriorityQueue<(Action, DateTime), DateTime>();
        }

        // Schedule a function to run after a delay (in seconds).
        public void AddLater(Action func, double delay)
        {
            // Compute the deadline based on current time + delay.
            var deadline = DateTime.Now.AddSeconds(delay);

            // Push into the priority queue, using 'deadline' as the priority.
            _sleeping.Enqueue((func, deadline), deadline);
        }

        // Immediately add a function to the "ready" queue.
        public void Add(Action func)
        {
            _ready.Enqueue(func);
        }

        public void Run()
        {
            // Move any tasks whose deadlines have passed into the ready queue.
            while (_sleeping.Count > 0)
            {
                var (func, deadline) = _sleeping.Peek(); // look at the earliest deadline
                if (DateTime.Now >= deadline)
                {
                    // Deadline reached, dequeue and add to ready queue
                    _sleeping.Dequeue();
                    _ready.Enqueue(func);
                }
                else
                {
                    // Not time yet for the earliest item, so break
                    break;
                }
            }

            // Run everything that's currently ready.
            while (_ready.Count > 0)
            {
                var func = _ready.Dequeue();
                func?.Invoke();
            }
            Thread.Sleep(TimeSpan.FromSeconds(0.5));
            Run();
        }
    }


    public class EventLoopThreading
    {
        async Task<string> CountUp(int stop)
        {
            var x = 0;
            while (x < stop)
            {
                Console.WriteLine("Up " + x);
                await Task.Delay(1000);
                x++;
            }
            return "Done";
        }

        async Task<string> CountDown(int n)
        {
            while (n > 0)
            {
                Console.WriteLine("Down " + n);
                await Task.Delay(1000);
                n--;
            }
            return "Done";
        }

        public void GO()
        {
            Task.WaitAll(CountUp(5), CountDown(5));
        }
    }
}


