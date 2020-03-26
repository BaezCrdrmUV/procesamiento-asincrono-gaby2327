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
> En este ejemplo, algunas de las instrucciones se ejecutarán a destiempo. Si ejecutamos este ejemplo veremos imprimirse ‘Primero’, ‘Tercero’, ‘Segundo’. Esto porque estamos usando la instrucción setTimeout() que difiere de la ejecución x milisegundos.

### Acerca de
>* Creado en C#
>* Por: Gabriela Sandoval Cruz
