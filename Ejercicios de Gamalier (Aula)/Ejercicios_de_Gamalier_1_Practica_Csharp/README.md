# Sistema de Reserva de Asientos de Cine 🎬

Este proyecto es una práctica en C# que implementa un sistema de reserva de asientos de cine utilizando la consola. La aplicación permite que el usuario elija un asiento en una matriz de 10 filas y 10 columnas y realiza un seguimiento de los asientos ocupados y libres.

## Descripción 📖

El sistema utiliza una matriz de 10x10 que representa la disposición de los asientos en una sala de cine. Cada asiento se muestra con un símbolo:
- `L` si el asiento está **libre**.
- `X` si el asiento está **ocupado**.

Al inicio, todos los asientos están marcados con `L`. El usuario puede seleccionar una fila y columna, y el sistema verificará si el asiento está disponible antes de reservarlo. De esta manera, no se permite la sobreventa, asegurando que los asientos ocupados no puedan volver a ser seleccionados.

## Características ✨

- **Matriz de 10x10** para representar los asientos de la sala de cine.
- **Interfaz en consola** que permite la selección de asientos.
- **Control de ocupación**: los asientos reservados se marcan como ocupados (`X`).
- **Prevención de sobreventa**: si un usuario intenta reservar un asiento ocupado, el sistema le notificará y le pedirá que elija otro.

## Uso 🚀

1. Al ejecutar el programa, se muestra el estado inicial de la sala con todos los asientos libres (`L`).
2. El usuario selecciona la fila y columna del asiento deseado.
3. El sistema verifica si el asiento está libre. Si está libre, cambia el estado a `X`; de lo contrario, informa al usuario y pide otra selección.
4. El proceso continúa hasta que el usuario decida salir.

## Tecnologías Utilizadas 🛠️

- **Lenguaje**: C#
- **Entorno**: Consola

## Contribución 🖊️

Este proyecto fue realizado como práctica para mejorar habilidades en programación con C# y el uso de matrices en aplicaciones de consola.

¡Gracias por revisar este proyecto!