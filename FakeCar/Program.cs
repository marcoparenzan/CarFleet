using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading.Tasks;

namespace FakeCar
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var hostName = args[0];
            var deviceId = args[1];
            var deviceKey = args[2];

            var authentication = new DeviceAuthenticationWithRegistrySymmetricKey(deviceId, deviceKey);

            var client = 
                DeviceClient.Create(
                    hostName,
                    authentication, 
                    TransportType.Mqtt_WebSocket_Only);

            var random = new Random();
            var velocita = 80;

            while (true)
            {
                velocita += random.Next(-5, 5);

                var ev = new
                {
                    carId = deviceId,
                    velocita = velocita,
                    t = DateTime.Now
                };
                var json = JsonConvert.SerializeObject(ev);
                var bytes = Encoding.UTF8.GetBytes(json);

                var message = new Message(bytes);

                await client.SendEventAsync(message);

                Console.WriteLine(json);

                await Task.Delay(1000);
            }
        }
    }
}
