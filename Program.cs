using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.Todo - list
//Главное меню программы включает следующие пронумерованные пункты:
//1.добавление новой задачи
//2.поиск задач по тэгам вывод N наиболее актуальных задач
//3.выход.

//Для выбора нужного пункта меню пользователь вводит соответствующий номер.
//При добавлении новой задачи пользователь последовательно вводит
//тему задачи, описание, дату к которой задача должна быть готова и тэги.
//Ввод тэгов продолжается до тех пор, пока пользователь не введёт пустую строку.
//Для поиска пользователь вводит через пробел ключевые слова, наличие которых среди тэгов задачи является критерием выборки.

//Вывод актуальных задач осуществляется в отсортированном по дате готовности порядке.

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int comanda;
            string NameTag = "";
            comanda = Convert.ToInt16(Console.Read());
            TodoList todoList = new TodoList();
            var task = new TodoTask();

            //1.добавление новой задачи
            if (comanda == 1)
            {
                NameTag = Convert.ToString(Console.Read());
                task.AddTag(NameTag);
                todoList.Add(task);
            }

            //2.поиск задач по тэгам вывод N наиболее актуальных задач
            if (comanda == 2)
            {
                NameTag = Convert.ToString(Console.Read());
                //Ввод тэгов продолжается до тех пор, пока пользователь не введёт пустую строку.
                while (NameTag != "")
                {
                    task.HasTag(NameTag);
                    NameTag = Convert.ToString(Console.Read());
                }
            }

            //3.выход.
            if (comanda == 3)
            {
                throw new NotImplementedException("");
            }

            //4.удаление тэга 
            if (comanda == 4)
            {
                NameTag = Convert.ToString(Console.Read());
                task.RemoveTag(NameTag);
            }
        }
    }
}
