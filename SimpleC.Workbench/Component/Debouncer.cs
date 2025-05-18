using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleC.Workbench.Component
{
    public class Debouncer
    {
        // Debounce actions (by hashcode) to wait until the timer has elapsed - at which point you "pop"
        // the action and clear it out. Should any other actions (of the same hash code) be entered in, 
        // the value is incremented (by one) to wait another interval to call the action.
        //
        Dictionary<Action, int> _actionDict;

        Timer _timer;
        object _lock = new object();

        List<Action> _dueList;

        public Debouncer(int intervalMilliseconds)
        {
            if (intervalMilliseconds < 50)
                throw new ArgumentException("Debouncer interval must be greater than or equal to 50 milliseconds");

            _dueList = new List<Action>();
            _actionDict = new Dictionary<Action, int>();
            _timer = new Timer(new TimerCallback(OnTimer));
            _timer.Change(intervalMilliseconds, intervalMilliseconds);
        }
        ~Debouncer()
        {
            _timer.Dispose();
        }

        public void Debounce(Action action)
        {
            lock(_lock)
            {
                if (!_actionDict.ContainsKey(action))
                    _actionDict.Add(action, 0);

                else
                    _actionDict[action] = 1;
            }
        }

        void OnTimer(object? state)
        {
            lock (_lock)
            {
                if (_actionDict.Count > 0)
                {
                    _dueList.Clear();

                    // Call each pending action
                    foreach (var action in _actionDict.Keys)
                    {
                        if (_actionDict[action] > 0)
                            _actionDict[action]--;

                        if (_actionDict[action] == 0)
                            _dueList.Add(action);
                    }

                    foreach (var action in _dueList)
                    {
                        // Run the action
                        action();

                        _actionDict.Remove(action);
                    }
                }
            }
        }
    }
}
