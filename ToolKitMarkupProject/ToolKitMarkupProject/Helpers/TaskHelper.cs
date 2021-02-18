using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ToolKitMarkupProject.Helpers
{
    public static class TaskHelper
    {
        private static TaskScheduler uiTaskScheduler;
        private static TaskFactory uiTaskFactory;

        /// <summary>
        /// Call this method from the UI thread at application start, before you call RunOnUIThread
        /// </summary>
        public static void InitializeFromUIThread()
        {
            uiTaskScheduler = TaskScheduler.FromCurrentSynchronizationContext();
            uiTaskFactory = new TaskFactory(CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskContinuationOptions.None, uiTaskScheduler);
        }

        public static Task RunOnUIThread(Func<Task> asyncAction) => uiTaskFactory.StartNew(asyncAction).Unwrap();

        public static Task<T> RunOnUIThread<T>(Func<Task<T>> asyncFunction) => uiTaskFactory.StartNew(asyncFunction).Unwrap();

        public static Task RunOnUIThread(Action action)
        {
            // If we are already on the UI thread, execute the action inline.
            if (TaskScheduler.Current?.Id == uiTaskScheduler.Id) // We are already on the UI thread; excecute the action inline
            {
                action();
                return Task.CompletedTask;
            }

            return uiTaskFactory.StartNew(action);
        }

        public static Task<T> RunOnUIThread<T>(Func<T> function)
        {
            // If we are already on the UI thread, execute the function inline.
            if (TaskScheduler.Current?.Id == uiTaskScheduler.Id) // We are already on the UI thread; excecute the action inline
            {
                T result = function();
                return Task.FromResult(result);
            }

            return uiTaskFactory.StartNew(function);
        }
    }
}