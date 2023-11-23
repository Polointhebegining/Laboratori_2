using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    public class TodoList
    {
        private readonly List<TodoTask> tasks = new List<TodoTask>();

        public IEnumerable<TodoTask> Tasks
        {
            get
            {
                return tasks;
            }

        }

        public IEnumerable<TodoTask> CompletedTasks
        {
            get
            {
                foreach (TodoTask task in tasks)
                {
                    if (task.IsCompleted)
                    {
                        yield return task;
                    }
                }
            }
        }

        public IEnumerable<TodoTask> UncompletedTasks
        {
            get
            {
                foreach (TodoTask task in tasks)
                {
                    if (!task.IsCompleted)
                    {
                        yield return task;
                    }
                }
            }
        }

        public void Add(TodoTask task)
        {
            tasks.Add(task);
        }

        public void Remove(TodoTask task)
        {
            tasks.Remove(task);
        }

        public IEnumerable<TodoTask> Search(string tag)
        {
            //TodoTask list = new TodoTask();
            //List <string> tagi = list.Tags;
            //for (int i = 1; i <= tagi.Count(); i++)
            //{
            //    if (tagi[i] == tags) { 
            //        return list; 
            //    }
            //}
            //return null;

            var result = new List<TodoTask>();

            foreach (var task in tasks)
            {
                if (task.Tags.Contains(tag))
                {
                    result.Add(task);
                    continue;
                }
            }

            return result;
        }
    }

}
