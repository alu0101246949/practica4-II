# Ejercicios Práctica 4: Interfaces Inteligentes

Realizado por: Laura Ramallo Pérez  
Asignatura: Interfaces Inteligentes

## Descripción:

A lo largo de esta práctica, se desarrollaron diversas mecánicas de juego utilizando Unity:

### 1. Interacción Cubo-Cilindro:

- Se implementó una mecánica donde, al colisionar el cubo con el cilindro, las esferas de tipo 1 cambian su color y las esferas de tipo 2 se desplazan hacia el cilindro.
- Se utilizaron los eventos `OnCollider` o `OnTrigger` para detectar la colisión. Cuando el cilindro detecta la colisión, envía un mensaje al que las esferas están suscritas y reaccionan en consecuencia.
![image](https://github.com/alu0101246949/practica4-II/assets/114754476/0a9e2da2-9485-43dc-93b7-25ea3fb7dc5e)

### 2. Adaptación de la Escena:

- La mecánica se amplió para que cuando el cubo colisionara con cualquier objeto (excepto las esferas de tipo 1), las esferas de tipo 1 se acercaran al cilindro.
- Además, cuando el cubo colisiona con las esferas de tipo 1, las esferas de tipo 2 aumentan de tamaño.
- Se sugirió el uso de prefabs para generar esferas con características consistentes.
![image](https://github.com/alu0101246949/practica4-II/assets/114754476/b25fb196-6562-452e-b833-8995aa6b77a1)

### 3. Proximidad del Cubo al Cilindro:

- Se añadió una funcionalidad para que, cuando el cubo se aproxima al cilindro, las esferas de tipo 1 cambien su color y realicen un movimiento de salto.
- Las esferas de tipo 2, por otro lado, se orientan hacia un objeto específico en la escena.

### 4. Mecánica de Recolección:

- Se implementó una mecánica donde el cubo puede "recoger" esferas en la escena, lo que actualiza la puntuación del jugador.
- Las esferas de tipo 1 suman 5 puntos, mientras que las esferas de tipo 2 suman 10 puntos.
- La puntuación se muestra en la consola de Unity.

### 5. Interfaz de Puntuación:

- Se añadió una interfaz de usuario (UI) en la escena para mostrar la puntuación actual del jugador en tiempo real.
- Se utilizó el objeto Canvas de Unity y un componente de texto para mostrar la puntuación.

### 6. Creación de la Escena de Prototipo:

- **Terreno**: Creado para actuar como suelo y escenario de juego.
  
- **Iluminación**: Añadida luz direccional, similar a la luz del sol.

- **Cámara**: Configurada para seguir al cubo y mostrar la acción.

- **Cubo (Jugador)**: 
  - Representa al jugador o personaje principal.
  - Equipado con scripts para interacciones y movimiento.

- **Cilindro**: Objeto interactivo que influye en el comportamiento de las esferas.

- **Esferas**: 
  - Esparcidas por el terreno en dos variantes.
  - Reaccionan al cubo basándose en interacciones definidas previamente.

- **Mecánicas**:
  - Implementadas para gestionar colisiones y proximidad.
  - Las esferas cambian según las acciones del cubo.

- **UI**: 
  - Interfaz sencilla mostrando puntuación del jugador en tiempo real.
