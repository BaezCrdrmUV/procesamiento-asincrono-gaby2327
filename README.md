# Procesamiento Asíncrono
- ¿Qué es el procesamiento asíncrono?
- ¿En qué escenarios se utiliza?
- Ejemplo en lenguaje de programación favorito.

## Respuestas
- ¿Qué es el procesamiento asíncrono?
>* Un proceso asíncrono es un proceso o una función que ejecuta una tarea "en segundo plano" sin que el usuario tenga que esperar a que finalice la tarea.
>* Un proceso asíncrono evita que nuestras tareas a realizar pasen por el mismo hilo ejecutando un nuevo hilo cuando esta es llamada. De esta manera no se quedará en espera a que la tarea anterior termine, sino, comenzará la tarea usando un nuevo hilo.

- ¿En qué escenarios se utiliza?
> Se suele usar para llamadas a sistemas externos, un tipo de operaciones que requieren límites superiores y un código que se debe ejecutar en un momento determinado. Las ventajas clave del procesamiento asíncrono son eficiencia del usuario y adaptabilidad.
  
- Ejemplo en lenguaje de programación favorito.
> En este ejemplo, se permite mejorar la reactividad de una aplicación. Para ello utilizaremos la palabra reservada async y await.
> Si la entrada fuera 100000000 puede tardar bastante el cálculo. Para mejorar el comportamiento se proporciona al usuario terminar la ejecución de la aplicación sin necesidad de ir al administrador de tareas de Windows.

### Acerca de
>* Creado en C#
>* Por: Gabriela Sandoval Cruz

#### Referencias
* Corzo, G. (2018, 19 junio). Programación Así­ncrona. Recuperado 25 marzo, 2020, de https://medium.com/laboratoria-how-to/programacion-asincrona-cea3bad7c3c6
* Tutorial sobre programación asíncrona con C# y ejemplos prácticos. (2017, 9 diciembre). Recuperado 25 marzo, 2020, de https://anexsoft.com/tutorial-sobre-programacion-asincrona-con-c-y-ejemplos-practicos
* Apex así­ncrono. (s.f.). Recuperado 25 marzo, 2020, de https://trailhead.salesforce.com/es-MX/content/learn/modules/asynchronous_apex/async_apex_introduction
* Grill, T. (s.f.-b). Funciones asíncronas – Tutorial de C#. Recuperado 25 marzo, 2020, de https://csharp.com.es/funciones-asincronas/
