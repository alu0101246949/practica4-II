# Ejercicios Práctica 4: Interfaces Inteligentes

Realizado por: Laura Ramallo Pérez  
Asignatura: Interfaces Inteligentes

## Descripción:

A lo largo de esta práctica, se desarrollaron diversas mecánicas de juego utilizando Unity:

### 1. Interacción Cubo-Cilindro:

- Se implementó una mecánica donde, al colisionar el cubo con el cilindro, las esferas de tipo 1 cambian su color y las esferas de tipo 2 se desplazan hacia el cilindro.
- Se utilizaron los eventos `OnCollider` o `OnTrigger` para detectar la colisión. Cuando el cilindro detecta la colisión, envía un mensaje al que las esferas están suscritas y reaccionan en consecuencia.
 
![01](https://github.com/alu0101246949/practica4-II/assets/114754476/5526220c-0286-49d6-93a9-a58e4f629d22)

### 2. Adaptación de la Escena:

- La mecánica se amplió para que cuando el cubo colisionara con cualquier objeto (excepto las esferas de tipo 1), las esferas de tipo 1 se acercaran al cilindro.
- Además, cuando el cubo colisiona con las esferas de tipo 1, las esferas de tipo 2 aumentan de tamaño.

![02](https://github.com/alu0101246949/practica4-II/assets/114754476/41c54d26-468c-4375-a694-92c320838df4)


### 3. Proximidad del Cubo al Cilindro:

- Se añadió una funcionalidad para que, cuando el cubo se aproxima al cilindro, las esferas de tipo 1 cambien su color y realicen un movimiento de salto.
- Las esferas de tipo 2, por otro lado, se orientan hacia un objeto específico en la escena.
  
![03](https://github.com/alu0101246949/practica4-II/assets/114754476/d937eb26-5778-4d37-a382-ca04e781f1cf)

### 4. Mecánica de Recolección:

- Se implementó una mecánica donde el cubo puede "recoger" esferas en la escena, lo que actualiza la puntuación del jugador.
- Las esferas de tipo 1 suman 5 puntos, mientras que las esferas de tipo 2 suman 10 puntos.
- La puntuación se muestra en la consola de Unity.

![04 1](https://github.com/alu0101246949/practica4-II/assets/114754476/dd55490a-1509-43d5-b968-4bdc40162c67)
![04](https://github.com/alu0101246949/practica4-II/assets/114754476/8cb2c839-67a5-440d-b48c-5f833407b704)


### 5. Interfaz de Puntuación:

- Se añadió una interfaz de usuario (UI) en la escena para mostrar la puntuación actual del jugador en tiempo real.
  
![05](https://github.com/alu0101246949/practica4-II/assets/114754476/3aa81b39-9335-483d-a9df-233e16e633f6)
![05 1](https://github.com/alu0101246949/practica4-II/assets/114754476/86a4247f-5937-4113-b788-a0bc9197d656)

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
