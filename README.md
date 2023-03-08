# MissionPlanner

![779088](https://user-images.githubusercontent.com/29682017/223854774-71f8b0a8-d8f4-4326-8f69-a641e959a359.png)

# Logger
English:
Tiny library that allows to send strings to a ".log" file, which are stored in the application location folder, also creates folders per year, per month and creates "log" files per day.

Español:
Pequeña libreria que permite enviar strings a un archivo .log, los cuales se almacenan en la ubicacion de la aplicacion, en carpetas por año, por mes y crea archivos por dia

## How to use it (Como usarlo)
### Option 1:
```C#
      var serviceProvider = new ServiceCollection()
           .AddTransient<ILogger>(provider => new FileLogger())
           .BuildServiceProvider();

      var logger = serviceProvider.GetService<ILogger>();

      //Just for test
      //Escribe el mensaje que quieres registrar en el archivo de log:
      Console.WriteLine("Write here some text to send to the log file: "); 
      string message = Console.ReadLine();

      logger.Log(message);

      //El mensaje ha sido registrado en el archivo de log.
      Console.WriteLine("The message has been recorded in the log file...");
      Console.ReadLine();
```      
### Option 2:
```C#
      ILogger logger = new FileLogger();
      
      //Escribe el mensaje que quieres registrar en el archivo de log:
      Console.WriteLine("Write here some text to send to the log file: "); 
      string message = Console.ReadLine();

      logger.Log(message);
      
      //El mensaje ha sido registrado en el archivo de log.
      Console.WriteLine("The message has been recorded in the log file...");
      Console.ReadLine();
```    
