using System;

namespace vp_lab_4
{
    // Двусвязные списки также представляют последовательность связанных узлов,
    // каждый узел хранит ссылку на следующий и на предыдущий элементы.

    // Шаблон двухсвязный список
    public class GenericsSet<T> where T : IEquatable<T>
    {
        public uint Count { get; set; }  // Количество элемент в списке

        private Node<T> head;   // Первый элемент списка
        private Node<T> tail;   // Конечный элемент списка

        // Класс элемент списка
        private class Node<T>
        {
            public T Data; // Данные элемента

            public Node<T> Next { get; set; } // Cсылка на следующий элемент
            public Node<T> Previos { get; set; } // Cсылка на предыдущий элемент

            // Конcтруктор элемента списка
            public Node(T data)
            {
                Data = data;
            }
        }

        // Добавление нового элемента в коллекцию
        public void Add(T elements)
        {
            // Создание нового элемента списка
            Node<T> node = new Node<T>(elements);

            if (head == null)   // Если список пуст
            {
                head = node;    // Устанавливаем новый элемент, как начальный элемент списка
            }
            else
            {
                tail.Next = node;   // Ссылаемся на новый элемент списка, как на следующий, в хвоставом элементе
                node.Previos = tail;    // Ссылаемся на хвостовой элемент списка, как на предшественника, в новом элементе 
            }

            tail = node;    // Актуализируем данные о последнем элементе списка
            Count++;    // Актуализируем данные о количестве элементов в списке
        }

        // Получение элемента списка по порядковому номеру
        public T Get(int index)
        {
            if (index < Count)  // Проверка на область допустимых значений
            {
                Node<T> result = head;  // Первый элемент списка

                // Спускаемся до нужного элемента
                for (int i = 1; i < index; i++)
                {
                    result = result.Next;
                }

                // Возвращаем значение элемента
                return result.Data; 
            }
            else throw new IndexOutOfRangeException();
        }
    }
}
