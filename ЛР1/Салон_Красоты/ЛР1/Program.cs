using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР1
{
    public class Client
    {
        public string Name { get; set; }
        public List<string> ServicesUsed { get; set; } = new List<string>();

        public Client(string name)
        {
            Name = name;
        }
    }

    public class BeautySalon
    {
        private List<Client> clients = new List<Client>();

        public void AddClient(Client client)
        {
            clients.Add(client);
        }

        // Метод для поиска клиентов, пользовавшихся определенной услугой, отсортированных по частоте использования
        public List<Client> FindClientsByService(string serviceName)
        {
            // Создаем словарь для подсчета количества использований услуги каждым клиентом
            Dictionary<Client, int> serviceUsageCount = new Dictionary<Client, int>();

            foreach (var client in clients)
            {
                int count = client.ServicesUsed.Count(s => s.Equals(serviceName, StringComparison.OrdinalIgnoreCase)); //Поиск без учета регистра
                if (count > 0)
                {
                    serviceUsageCount[client] = count;
                }
            }

            // Сортируем клиентов по убыванию количества использований услуги
            List<Client> sortedClients = serviceUsageCount.OrderByDescending(kvp => kvp.Value)
                                                          .Select(kvp => kvp.Key)
                                                          .ToList();

            return sortedClients;
        }

        // Метод для подсчета среднего количества обращений по заданной услуге
        public double CalculateAverageServiceUsage(string serviceName)
        {
            if (clients.Count == 0)
            {
                return 0; // Избегаем деления на ноль, если нет клиентов
            }

            int totalUsageCount = 0;
            foreach (var client in clients)
            {
                totalUsageCount += client.ServicesUsed.Count(s => s.Equals(serviceName, StringComparison.OrdinalIgnoreCase)); //Поиск без учета регистра
            }

            return (double)totalUsageCount / clients.Count;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Создаем экземпляр салона красоты
            BeautySalon salon = new BeautySalon();

            // Создаем клиентов и добавляем их в салон
            Client client1 = new Client("Алиса");
            client1.ServicesUsed.Add("Стрижка");
            client1.ServicesUsed.Add("Маникюр");
            client1.ServicesUsed.Add("Стрижка");
            client1.ServicesUsed.Add("Стрижка");

            Client client2 = new Client("Боб");
            client2.ServicesUsed.Add("Маникюр");
            client2.ServicesUsed.Add("Чистка лица");
            client2.ServicesUsed.Add("Маникюр");

            Client client3 = new Client("Чарли");
            client3.ServicesUsed.Add("Стрижка");
            client3.ServicesUsed.Add("Чистка лица");

            salon.AddClient(client1);
            salon.AddClient(client2);
            salon.AddClient(client3);

            // Запрашиваем у пользователя название услуги
            Console.Write("Введите название услуги: ");
            string serviceName = Console.ReadLine();

            // Получаем список клиентов, пользовавшихся данной услугой, отсортированный по частоте использования
            List<Client> clientsUsingService = salon.FindClientsByService(serviceName);

            // Выводим список клиентов на экран
            Console.WriteLine($"\nКлиенты, которые пользовались услугой '{serviceName}', отсортированы по частоте использования:");
            foreach (var client in clientsUsingService)
            {
                int usageCount = client.ServicesUsed.Count(s => s.Equals(serviceName, StringComparison.OrdinalIgnoreCase));
                Console.WriteLine($"- {client.Name} (Использовали {usageCount} в это время)");
            }

            // Подсчитываем и выводим среднее количество обращений по данной услуге
            double averageUsage = salon.CalculateAverageServiceUsage(serviceName);
            Console.WriteLine($"\nСреднее использование '{serviceName}': {averageUsage:F2}");

            Console.ReadKey();
        }
    }
}
